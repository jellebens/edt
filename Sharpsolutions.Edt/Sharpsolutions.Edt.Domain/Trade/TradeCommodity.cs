using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Domain.Trade {
    public class TradeCommodity {
        public Commodity Commodity { get; set; }
        public int Price { get; set; }
    }
}
