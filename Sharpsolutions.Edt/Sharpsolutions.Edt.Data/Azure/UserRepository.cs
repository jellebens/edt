using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.WindowsAzure.Storage.Table;
using Newtonsoft.Json;
using Sharpsolutions.Edt.Domain.Account;
using Sharpsolutions.Edt.System.Domain;

namespace Sharpsolutions.Edt.Data.Azure {
    public class UserRepository : TableStorageBase<User>, IUserRepository {


        protected override string Table { get { return "users"; } }
        protected override string GetPartitionKey(User root)
        {
            return root.Username;
        }
        
        public User Get(string id)
        {
            CloudTable table = Build();

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
