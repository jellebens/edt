using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;
using Sharpsolutions.Edt.Domain.Trade;
using Sharpsolutions.Edt.System.Data;

namespace Sharpsolutions.Edt.Data.Azure {
    public class StarportRepository : TableStorageBase<Starport> {

        protected override string Table {
            get { return "starport"; }
        }

        public override void Add(Starport item)
        {
            DynamicTableEntity entity = new DynamicTableEntity(item.Id().Partition, item.Id().Row);

            entity.Properties.Add("Name", new EntityProperty(item.Name));
            entity.Properties.Add("SolarSystem", new EntityProperty(item.System.Name));
            entity.Properties.Add("Economy", new EntityProperty(item.Economy.DisplayName));


            CloudTable starportTable = Build();

            TableOperation insertOperation = TableOperation.Insert(entity);

            CloudTable starportGoods = Build("starportgoods");

            TableBatchOperation goodsOperation = new TableBatchOperation();

            foreach (StockItem stockItem in item.Goods)
            {
                DynamicTableEntity goodEntity = new DynamicTableEntity(item.Id().Row, stockItem.Commodity.Name.ToLower());
                goodEntity.Properties.Add("Commodity", new EntityProperty(stockItem.Commodity.Name));
                goodEntity.Properties.Add("Exports", new EntityProperty(stockItem.Exports));
                goodEntity.Properties.Add("Imports", new EntityProperty(stockItem.Imports));

                goodsOperation.Insert(goodEntity);
            }

            starportTable.Execute(insertOperation);
            starportGoods.ExecuteBatch(goodsOperation);
        }

        public override Starport Get(string rowId) {
            throw new NotImplementedException();
        }
    }
}
