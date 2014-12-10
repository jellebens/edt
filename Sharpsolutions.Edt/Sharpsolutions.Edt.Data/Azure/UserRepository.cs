using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Sharpsolutions.Edt.Domain.Account;
using Sharpsolutions.Edt.System;
using Sharpsolutions.Edt.System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Data.Azure {
    public class UserRepository : TableStorageBase<User> {
        protected override string Table {
            get { return "users"; }
        }

        public override void Add(User user) {

            CloudTable table = Build();


            DynamicTableEntity entity = new DynamicTableEntity();

            entity.PartitionKey = user.Name;
            entity.RowKey = user.Name;
            entity.Properties.Add("Name", new EntityProperty(user.Name));
            entity.Properties.Add("Password", new EntityProperty(user.Password.ToString()));


            TableOperation insertOperation = TableOperation.Insert(entity);

            table.Execute(insertOperation);
        }

        public override User Get(string id) {

            CloudTable table = Build();

            DynamicTableEntity entity = new DynamicTableEntity();
            Dictionary<string, EntityProperty> props = new Dictionary<string, EntityProperty>();
            TableOperation retrieveOperation = TableOperation.Retrieve(id, id);

            TableResult retrievedResult = table.Execute(retrieveOperation);

            DynamicTableEntity x = retrievedResult.Result as DynamicTableEntity;

            if (x == null) {
                return null;
            }

            var u = Map(x);

            return u;

        }

        private static User Map(DynamicTableEntity x)
        {
            Password p = new Password(x.Properties["Password"].StringValue);
            User u = new User(x.Properties["Name"].StringValue, p);
            return u;
        }

    }
}
