using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;
using Sharpsolutions.Edt.System.Domain;

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
