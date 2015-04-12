using Microsoft.WindowsAzure.Storage.Table;

namespace Sharpsolutions.Edt.Data.Azure {
    public class EventEntity : TableEntity {
        public EventEntity()
        {
        }

        public EventEntity(string partitionKey, string rowKey) : base(partitionKey, rowKey) {

        }

        public string Payload { get; set; }

    }
}
