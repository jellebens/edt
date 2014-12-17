using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace Sharpsolutions.Edt.Api.Models.Trade {
    public class StockUpdateViewModel {
        [Required]
        [Display(Name = "Starport name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Solar System name")]
        public string System { get; set; }
        public IList<StockUpdateModel> Goods { get; set; }
        
    }
}