using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sharpsolutions.Edt.Api.Models.Trade {
    public class StarportUpdateModel {
        public string Name { get; set; }

        public string System { get; set; }
        public string Economy { get; set; }

        public StockItemModel[] Goods { get; set; }
    }
}