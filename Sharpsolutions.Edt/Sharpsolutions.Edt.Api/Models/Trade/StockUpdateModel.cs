using System.ComponentModel.DataAnnotations;

namespace Sharpsolutions.Edt.Api.Models.Trade
{
    public class StockUpdateModel {
        [Required]
        [Display(Name = "Category name")]
        public string Category { get; set; }
        [Required]
        [Display(Name = "Commodity name")]
        public string Name { get; set; }
        [Display(Name = "Sell Price")]
        public int? Sell { get; set; }
        [Display(Name = "Buy Price")]
        public int? Buy { get; set; }
    }
}