using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Sharpsolutions.Edt.Data.Azure.Mappers;
using Sharpsolutions.Edt.Domain.Account;
using Sharpsolutions.Edt.System;
using Sharpsolutions.Edt.System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Data.Azure {
    public class UserTableStoreRepository : IRepository<User, string> {
        public void Add(User user) {

            CloudTable table = Build();


            UserEntity ent = new UserEntity(user);

            TableOperation insertOperation = TableOperation.Insert(ent);

            table.Execute(insertOperation);
        }

         public User Get(string id) {
           
            CloudTable table = Build();

            TableOperation RetrieveOperation = TableOperation.Retrieve<UserEntity>(id, id);

            TableResult retrievedResult = table.Execute(RetrieveOperation);



            UserEntity result = (UserEntity)retrievedResult.Result;

            if (result != null) {
                return result.AsDomain();
            }

            return null;
             
        }

        private static CloudTable Build() {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
            CloudConfigurationManager.GetSetting(Settings.Storage.Table.ConfigKey));
            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

            CloudTable table = tableClient.GetTableReference("users");

            table.CreateIfNotExists();
            return table;
        }

       
    }
}
