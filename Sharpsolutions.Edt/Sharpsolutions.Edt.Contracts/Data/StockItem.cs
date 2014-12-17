using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Contracts.Data {
    public class StockItem {
        public string Category { get; set; }
        public string Name { get; set; }
        public char Supply { get; set; }
        public char Demand { get; set; }
        public int? Sell { get; set; }
        public int? Buy { get; set; }
    }
}
