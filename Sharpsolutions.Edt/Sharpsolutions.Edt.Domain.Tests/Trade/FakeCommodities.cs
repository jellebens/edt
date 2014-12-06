using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Domain.Tests.Trade {
    public class FakeCommodities
    {
        public static Commodity Silver = Commodity.CommodityFactory.Create("Silver", "Metals");
        public static Commodity Pesticides = Commodity.CommodityFactory.Create("Pesticides", "Chemicals");
        public static Commodity Biowaste = Commodity.CommodityFactory.Create("Biowaste", "Waste");
        public static Commodity Clothing = Commodity.CommodityFactory.Create("Clothing", "Consumer Items");
    }
}
