using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sharpsolutions.Edt.Api.Models.Trade {
    public class TradeRouteModel {
        public StarportModel Origin { get; set; }
        public StarportModel Destination { get; set; }

        public string Commodtiy { get; set; }

        public string Category { get; set; }

        public int Profit { get; set; }
    }
}