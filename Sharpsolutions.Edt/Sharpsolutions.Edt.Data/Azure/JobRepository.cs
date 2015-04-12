using System;
using Microsoft.WindowsAzure.Storage.Table;
using Sharpsolutions.Edt.System.Command;
using Sharpsolutions.Edt.System.Data;

namespace Sharpsolutions.Edt.Data.Azure {
    public class JobRepository: TableStorageBase<Job>, IJobRepository {
        protected override string Table => "jobs";

        protected override string GetPartitionKey(Job entity)
        {
            return entity.CommandId.ToString();
        }

        public void Add(Job job) {
            CloudTable table = Build();


            DynamicTableEntity entity = new DynamicTableEntity();

            entity.PartitionKey = GetPartitionKey(job);
            entity.RowKey = job.CommandId.ToString();
            entity.Properties.Add("Status", new EntityProperty(job.Status.Value));
            entity.Properties.Add("CommandId", new EntityProperty(job.CommandId));
			entity.Properties.Add("UpdatedOn", new EntityProperty(DateTime.UtcNow));

            TableOperation insertOperation = TableOperation.InsertOrReplace(entity);

            table.Execute(insertOperation);
        }

        public Job Get(Guid commandId) {
            CloudTable table = Build();

            TableOperation retrieveOperation = TableOperation.Retrieve(commandId.ToString(), commandId.ToString());

            TableResult retrievedResult = table.Execute(retrieveOperation);

            DynamicTableEntity x = retrievedResult.Result as DynamicTableEntity;

            if (x == null) {
                return null;
            }

            var job = Map(x);

            return job;
        }

        private Job Map(DynamicTableEntity x) {
            Guid commandId = x.Properties["CommandId"].GuidValue.Value;
            int status = x.Properties["Status"].Int32Value.Value;
            return Job.Load(commandId, status);
        }
    }
}
