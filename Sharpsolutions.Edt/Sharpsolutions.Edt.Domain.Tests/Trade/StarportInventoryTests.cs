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

            Starport azebanCity = FakeStarportBuilder.HuiMines();

            azebanCity.Update(hydrogenFuel, 17, 19);
            int? sellPrice = azebanCity.Goods.Single(x => x.Commodity == hydrogenFuel).Sell;
            int? buyPrice = azebanCity.Goods.Single(x => x.Commodity == hydrogenFuel).Buy;

            Assert.AreEqual(17, sellPrice);
            Assert.AreEqual(19, buyPrice);
        }

        [Test]
        public void ExportsHavingCommiditiesForSaleShouldReturnList()
        {
            Starport hui = FakeStarportBuilder.HuiMines();
            IEnumerable<TradeCommodity> exports = hui.Exports();

            Assert.IsNotNull(exports);
            Assert.AreEqual(5133, exports.Single(e => e.Commodity == FakeCommodities.Gallium).Price);
        }

        [Test]
        public void ImportsBuyingCommoditiesShouldReturnList() {
            Starport kaku = FakeStarportBuilder.Kaku();
            IEnumerable<TradeCommodity> imports = kaku.Imports();

            Assert.IsNotNull(imports);
            Assert.AreEqual(5818, imports.Single(e => e.Commodity == FakeCommodities.Gallium).Price);
        }
    }
}
