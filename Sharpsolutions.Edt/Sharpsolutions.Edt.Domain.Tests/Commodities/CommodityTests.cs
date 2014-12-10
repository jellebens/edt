using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Domain.Tests.Trade;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Domain.Tests.Commodities {
    public class CommodityTests
    {
        public void FactoryCreateShouldCreateNewCommodity()
        {
            Category metals = new Category("Metals");
            Commodity c = Commodity.CommodityFactory.Create("Silver", metals);

            Assert.IsNotNull(c);
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void FactoryCreateNoNameShouldThrowArgumentNull()
        {
            Commodity.CommodityFactory.Create(null, new Category("Drugs"));
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void FactoryCreateNoCategoryShouldThrowArgumentNull()
        {
            Commodity.CommodityFactory.Create("Silver", null);
        }

        [Test]
        public void EqualsShouldReturnTrue()
        {
            Commodity silver = Commodity.CommodityFactory.Create("Silver", new Category("Metals"));

            Assert.AreEqual(FakeCommodities.Silver, silver);
        }

        [Test]
        public void EqualsOperatorSameShouldReturnTrue()
        {
            Commodity silver = Commodity.CommodityFactory.Create("Silver", new Category("Metals"));

            Assert.IsTrue(silver == FakeCommodities.Silver);
        }

        [Test]
        public void EqualsOperatorHavingNullShoumdReturnFalse() {
            Commodity silver = Commodity.CommodityFactory.Create("Silver", new Category("Metals"));

            Assert.IsFalse(null == FakeCommodities.Silver);
        }

        [Test]
        public void EqualsOperatorHavingNullOnTheRightShoumdReturnFalse() {
            Commodity silver = Commodity.CommodityFactory.Create("Silver", new Category("Metals"));

            Assert.IsFalse(FakeCommodities.Silver == null);
        }

        [Test]
        public void EqulasHavingDiffrentShouldReturnFalse() {
            
            Assert.IsFalse(FakeCommodities.Silver == FakeCommodities.Pesticides);
        }
    }
}
