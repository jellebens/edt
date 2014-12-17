﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;

namespace Sharpsolutions.Edt.Domain.Trade {
    public class StockItem {

        public virtual Commodity Commodity { get; protected set; }
        public virtual bool Exports { get; protected set; }
        public virtual bool Imports { get; protected set; }
        public virtual long Id { get; protected set; }
        public virtual int? Sell { get; protected set; }
        public virtual int? Buy { get; protected set; }
        
        public void Update(int? sell, int? buy)
        {
            Sell = sell;
            Buy = buy;
            
        }
        
        public static StockItem New(Commodity commodity, bool exports, bool imports)
        {
            return new StockItem()
            {
                Commodity = commodity,
                Exports = exports,
                Imports = imports
            };
        }
    }
}
