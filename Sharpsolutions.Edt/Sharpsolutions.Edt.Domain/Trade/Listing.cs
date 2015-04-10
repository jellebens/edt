using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Domain.Trade {
    public class Listing {
        public Commodity Commodity { get; private set; }
        public int Supply { get; private set; }
        public int Demand { get; private set; }
        public int Buy { get; private set; }

        public int Sell { get; private set; }
    }
}
