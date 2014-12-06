using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Domain.Tests.Trade {
    [TestFixture]
    public class StarportTests {
        [Test]
        public void CreateNewIndustrialShouldPopulateTheGoods()
        {
            StarportBuilder builder = new StarportBuilder("Kaku Orbital", "Chemaku", Economy.Industrial);

            Starport kaku = builder.Build();

            Assert.NotNull(kaku);

            Assert.IsTrue(kaku.Sells(FakeCommodities.Clothing), "Should be selling Clothing");
            Assert.IsTrue(kaku.Buys(FakeCommodities.Clothing), "Should be buying Biowaste");
        }

        [Test]
        public void CreateNewExtractionShouldPopulateTheGoods() {
            StarportBuilder builder = new StarportBuilder("Extraction Station", "Chemaku", Economy.Extraction);

            Starport starport = builder.Build();

            Assert.NotNull(starport);

            Assert.IsTrue(starport.Sells(FakeCommodities.Biowaste), "Should be selling Biowaste");
            Assert.IsTrue(starport.Buys(FakeCommodities.Clothing), "Should be buying Clothing");
        }

    }
}
