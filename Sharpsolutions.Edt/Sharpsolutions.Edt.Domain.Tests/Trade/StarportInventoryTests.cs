using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Domain.Tests.Trade
{
    [TestFixture]
    public class StarportInventoryTests
    {
        [Test]
        public void UpdateHavingCommodityInDemandSellAndBuyValidUpdates()
        {
            Commodity hydrogenFuel = FakeCommodities.HydrogenFuel;

            Starport azebanCity = FakeStarportBuilder.AzebanCity();

            azebanCity.Update(hydrogenFuel, 17, 19);
            int? sellPrice = azebanCity.Goods.Single(x => x.Commodity == hydrogenFuel).Sell;
            int? buyPrice = azebanCity.Goods.Single(x => x.Commodity == hydrogenFuel).Buy;

            Assert.AreEqual(17, sellPrice);
            Assert.AreEqual(19, buyPrice);
        }
    }
}
