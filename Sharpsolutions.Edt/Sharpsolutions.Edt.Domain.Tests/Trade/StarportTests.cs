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
        private readonly FakeCommodities _commodities = new FakeCommodities();
        [Test]
        public void CreateNewIndustrialShouldPopulateTheGoods()
        {
            StarportBuilder builder = new StarportBuilder("Kaku Orbital", "Chemaku", Economy.Industrial, _commodities.AllCommodities());
            
            Starport kaku = builder.Build();

            Assert.NotNull(kaku);
            Assert.IsNotEmpty(kaku.Goods);
        }

        [Test]
        public void CreateNewExtractionShouldPopulateTheGoods()
        {
            Economy e = Economy.Extraction;
            StarportBuilder builder = new StarportBuilder(e.DisplayName, "Chemaku", e, _commodities.AllCommodities());

            Starport starport = builder.Build();

            Assert.NotNull(starport);

            Assert.IsNotEmpty(starport.Goods);
        }

        [Test]
        public void CreateNewRefineryShouldPopulateTheGoods() {
            Economy e = Economy.Refinery;
            StarportBuilder builder = new StarportBuilder(e.DisplayName, "Chemaku", e, _commodities.AllCommodities());

            Starport starport = builder.Build();

            Assert.NotNull(starport);

            Assert.IsNotEmpty(starport.Goods);
        }

        [Test]
        public void CreateNewAgricultureShouldPopulateTheGoods() {
            Economy e = Economy.Agriculture;
            StarportBuilder builder = new StarportBuilder(e.DisplayName, "Chemaku", e, _commodities.AllCommodities());

            Starport starport = builder.Build();

            Assert.NotNull(starport);
            Assert.IsNotEmpty(starport.Goods);
            
        }

        [Test]
        public void CreateNewHighTechShouldPopulateTheGoods() {
            Economy e = Economy.HighTech;
            StarportBuilder builder = new StarportBuilder(e.DisplayName, "Chemaku", e, _commodities.AllCommodities());

            Starport starport = builder.Build();

            Assert.NotNull(starport);

            Assert.IsNotEmpty(starport.Goods);
        }


    }
}
