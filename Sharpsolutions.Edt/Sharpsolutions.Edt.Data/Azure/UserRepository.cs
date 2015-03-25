using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Sharpsolutions.Edt.Domain.Account;
using Sharpsolutions.Edt.System;
using Sharpsolutions.Edt.System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sharpsolutions.Edt.System.Domain;

namespace Sharpsolutions.Edt.Data.Azure {
    public class UserRepository : IUserRepository {
        public void CommitChanges(User user) {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                                                                     CloudConfigurationManager.GetSetting(Settings.Storage.Table.ConfigKey));

            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

            CloudTable table = tableClient.GetTableReference("users");

            string partionKey = user.Username;
            string rowKey = user.Version.ToString("D20");

            table.CreateIfNotExists();


            TableBatchOperation batchOperation = new TableBatchOperation();
            if (user.PendingChanges.Any())
            {
                foreach (EventBase change in user.PendingChanges) {

                    EventEntity eventRecored = new EventEntity(partionKey, rowKey)
                    {
                        Payload = JsonConvert.SerializeObject(change, new JsonSerializerSettings()
                        {
                            TypeNameHandling = TypeNameHandling.All
                        })
                    };

                    batchOperation.Insert(eventRecored);
                }

                table.ExecuteBatch(batchOperation);
            }
            
            


        }

        public User Get(string id) {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                                                                    CloudConfigurationManager.GetSetting(Settings.Storage.Table.ConfigKey));

            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

            CloudTable table = tableClient.GetTableReference("users");

            TableQuery<EventEntity> query = new TableQuery<EventEntity>()
                .Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, id));

            List<EventBase> events = new List<EventBase>();
            foreach (EventEntity entity in table.ExecuteQuery(query)) {
                EventBase @event = JsonConvert.DeserializeObject(entity.Payload, new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.All
                }) as EventBase;

                events.Add(@event);
            }

            if (!events.Any()) {
                return null;
            }

            ConstructorInfo c = typeof(User).GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, Type.EmptyTypes, null);

            User u = (User)c.Invoke(null);

            ((IEventSourced)u).Load(events);

           
            return u;
        }



    }
}
