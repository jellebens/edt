using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Sharpsolutions.Edt.System;
using Sharpsolutions.Edt.System.Data;
using Sharpsolutions.Edt.System.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Data.Azure {
    public abstract class TableStorageBase<TEntity, TId> : IRepository<TEntity, TId>
     where TEntity : IEntity<TId> {
        protected abstract string Table { get; }
        public abstract void Add(TEntity item);
        public abstract TEntity Get(TId id);

        protected CloudTable Build() {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                                                                            CloudConfigurationManager.GetSetting(Settings.Storage.Table.ConfigKey));

            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

            CloudTable table = tableClient.GetTableReference(Table);

            table.CreateIfNotExists();

            return table;
        }
    }
}
