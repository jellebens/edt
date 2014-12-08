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
            Commodity c = Commodity.CommodityFactory.Create("Silver", "Metals");

            Assert.IsNotNull(c);
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void FactoryCreateNoNameShouldThrowArgumentNull()
        {
            Commodity.CommodityFactory.Create(null, "Drugs");
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void FactoryCreateNoCategoryShouldThrowArgumentNull()
        {
            Commodity.CommodityFactory.Create("Silver", " ");
        }

        [Test]
        public void EqualsShouldReturnTrue()
        {
            Commodity silver = Commodity.CommodityFactory.Create("Silver", "Metals");

            Assert.AreEqual(FakeCommodities.Silver, silver);
        }

        [Test]
        public void EqualsOperatorSameShouldReturnTrue()
        {
             Commodity silver = Commodity.CommodityFactory.Create("Silver", "Metals");

            Assert.IsTrue(silver == FakeCommodities.Silver);
        }

        [Test]
        public void EqualsOperatorHavingNullShoumdReturnFalse() {
            Commodity silver = Commodity.CommodityFactory.Create("Silver", "Metals");

            Assert.IsFalse(null == FakeCommodities.Silver);
        }

        [Test]
        public void EqualsOperatorHavingNullOnTheRightShoumdReturnFalse() {
            Commodity silver = Commodity.CommodityFactory.Create("Silver", "Metals");

            Assert.IsFalse(FakeCommodities.Silver == null);
        }

        [Test]
        public void EqulasHavingDiffrentShouldReturnFalse() {
            
            Assert.IsFalse(FakeCommodities.Silver == FakeCommodities.Pesticides);
        }
    }
}
