using System.Linq;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Newtonsoft.Json;
using Sharpsolutions.Edt.System;
using Sharpsolutions.Edt.System.Domain;

namespace Sharpsolutions.Edt.Data.Azure {
    public abstract class TableStorageBase<TRoot> where TRoot : AgregateRootBase
    {
        protected abstract string Table { get; }

        public void Init()
        {
            CloudTable table = Build();
            table.CreateIfNotExists();
        }

        protected CloudTable Build()
        {
            return Build(Table);
        }

        protected CloudTable Build(string tableName) {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                                                                            CloudConfigurationManager.GetSetting(Settings.Storage.Table.ConfigKey));

            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

            CloudTable table = tableClient.GetTableReference(tableName);

            table.CreateIfNotExists();

            return table;
        }

        public void CommitChanges(TRoot root)
        {
            string partitionKey = GetPartitionKey(root);
            string rowKey = root.Version.ToString("D20");

            CloudTable table = Build();

            TableBatchOperation batchOperation = new TableBatchOperation();
            if (root.PendingChanges.Any()) {
                foreach (EventBase change in root.PendingChanges) {
                    EventEntity eventRecored = new EventEntity(partitionKey, rowKey)
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

        protected abstract string GetPartitionKey(TRoot entity);
    }
}
