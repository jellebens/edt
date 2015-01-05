using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;

namespace Sharpsolutions.Edt.Domain.Trade {
    [DebuggerDisplay("{Commodity.Name}")]
    public class StockItem {

        public virtual Commodity Commodity { get; protected set; }
        public virtual long Id { get; protected set; }
        public virtual int? Sell { get; protected set; }
        public virtual int? Buy { get; protected set; }
        
        public void Update(int? sell, int? buy)
        {
            Sell = sell;
            Buy = buy;
            
        }
        
        public static StockItem New(Commodity commodity)
        {
            return new StockItem()
            {
                Commodity = commodity,
            };
        }
    }
}
