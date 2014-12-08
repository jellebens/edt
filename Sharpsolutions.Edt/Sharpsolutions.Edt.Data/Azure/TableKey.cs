using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Data.Azure {
    public class TableKey {
        public TableKey(string partitionKey, string rowKey)
        {
            this.Partition = partitionKey;
            this.Row = rowKey;
        }

        public string Partition { get; private set; }
        public string Row { get; private set; }
    }
}
