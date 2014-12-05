using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sharpsolutions.Edt.Api.Models.Universe {
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