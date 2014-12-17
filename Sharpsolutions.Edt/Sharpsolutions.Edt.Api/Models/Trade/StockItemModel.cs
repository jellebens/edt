using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Api.Models.Trade {
    public class StockItemModel {
        public string Name { get; set; }
        public bool Export { get; set; }
        public bool Import { get; set; }
        public int? Sell { get; set; }
        public int? Buy { get; set; }
        public string Category { get; set; }
    }
}