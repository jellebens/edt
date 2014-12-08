using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Domain.Tests.Commodities {
    [TestFixture]
    public class CategoryTests {
        private readonly Category _Metals = new Category("Metals");
        [Test]
        public void EqualsSameNameShouldEqual() {
            
            Category b = new Category("Metals");

            Assert.AreEqual(_Metals, b);
        }

        [Test]
        public void EqualsStringSameAsNameShouldBeEqual() {
            Assert.AreEqual("Metals", _Metals);
        }

        [Test]
        public void EqualsStringDifferentNameShouldNotBeEqual() {
            Assert.AreNotEqual("Medicines", _Metals);
        }

        [Test]
        public void EqualsDifferentShouldNotBeEqual() {
            Category b = new Category("Medicines");
            Assert.AreNotEqual(b, _Metals);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CtorEmptyStringShouldThrow() {
            new Category(" ");
        }




    }
}
