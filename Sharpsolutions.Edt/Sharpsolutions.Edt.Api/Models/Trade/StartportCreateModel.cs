using System.ComponentModel.DataAnnotations;

namespace Sharpsolutions.Edt.Api.Models.Trade {
    public class StartportCreateModel {
        [Required]
        [Display(Name = "Starport name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Solar System name")]
        public string System { get; set; }

        [Required]
        [Display(Name = "Economy")]
        public string Economy { get; set; }

    }
}