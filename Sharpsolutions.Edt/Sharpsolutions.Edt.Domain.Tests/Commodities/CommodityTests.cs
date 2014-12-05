using NUnit.Framework;
using Sharpsolutions.Edt.Domain.Commodities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Domain.Tests.Commodities {
    public class CommodityTests {
        public void FactoryCreateShouldCreateNewCommodity(){
            Commodity c = Commodity.CommodityFactory.Create("Silver", "Metals");

            Assert.IsNotNull(c);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FactoryCreateNoNameShouldThrowArgumentNull() {
            Commodity.CommodityFactory.Create(null, "Drugs");
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FactoryCreateNoCategoryShouldThrowArgumentNull() {
            Commodity.CommodityFactory.Create("Silver", " ");
        }
    }
}
