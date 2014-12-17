using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sharpsolutions.Edt.Api.Models.Trade {
    public class StarportDetailModel {
        
        public string Name { get; set; }
        
        public string System { get; set; }
        
        public string Economy { get; set; }

        public StockItemModel[] Goods { get; set; }
    }
}