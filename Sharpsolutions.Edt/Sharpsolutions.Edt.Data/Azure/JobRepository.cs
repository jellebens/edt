using Microsoft.WindowsAzure.Storage.Table;
using Sharpsolutions.Edt.System.Command;
using Sharpsolutions.Edt.System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Data.Azure {
    public class JobRepository: TableStorageBase<Job>, IJobRepository {
        protected override string Table {
            get {
                return "jobs";
            }
        }

        public void Add(Job job) {
            CloudTable table = Build();


            DynamicTableEntity entity = new DynamicTableEntity();

            entity.PartitionKey = job.CommandId.ToString();
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
