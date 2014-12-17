using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Contracts.Data {
    public class InventoryItem {
        public string Category { get; set; }
        public string Commodity { get; set; }
        public int? Sell { get; set; }
        public int? Buy { get; set; }
    }
}
