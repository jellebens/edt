using Microsoft.WindowsAzure.Storage.Table;
using Sharpsolutions.Edt.Domain.Commodities;
using Sharpsolutions.Edt.System.Data;
using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Data.Azure {
    public class CommodityRepository : TableStorageBase<Commodity, string> {
        protected override string Table {
            get { return "commodities"; }
        }

        public override void Add(Commodity commodity) {

            CloudTable table = Build();


            DynamicTableEntity entity = new DynamicTableEntity();

            entity.PartitionKey = commodity.Category.Name.ToLower();
            entity.RowKey = commodity.Id;
            entity.Properties.Add("Name", new EntityProperty(commodity.Name));
            entity.Properties.Add("Category", new EntityProperty(commodity.Category.Name));

            TableOperation insertOperation = TableOperation.Insert(entity);

            table.Execute(insertOperation);
        }

        public override Commodity Get(string id) {
             CloudTable table = Build();

            TableQuery<DynamicTableEntity> q = new TableQuery<DynamicTableEntity>();
            q.Where(TableQuery.GenerateFilterCondition("RowKey", QueryComparisons.Equal, id));

            DynamicTableEntity entity = table.ExecuteQuery(q).Single();
            
            Commodity commodity = new Commodity(entity.Properties["Name"].StringValue, entity.Properties["Category"].StringValue);

            return commodity;
        }
    }
}
