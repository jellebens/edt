using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Domain.Tests.Trade {
    public class FakeCommodities
    {
        public static Commodity Silver = Commodity.CommodityFactory.Create("Silver", new Category("Metals"));
        public static Commodity Pesticides = Commodity.CommodityFactory.Create("Pesticides", new Category("Chemicals"));
        public static Commodity Biowaste = Commodity.CommodityFactory.Create("Biowaste", new Category("Waste"));
        public static Commodity Clothing = Commodity.CommodityFactory.Create("Clothing", new Category("Consumer Items"));
    }
}
