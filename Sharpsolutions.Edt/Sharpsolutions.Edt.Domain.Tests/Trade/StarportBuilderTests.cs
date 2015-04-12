using NUnit.Framework;
using Sharpsolutions.Edt.Domain.Core;
using Sharpsolutions.Edt.Domain.Tests.Fakes;
using Sharpsolutions.Edt.Domain.Trade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Domain.Tests.Trade {

    [TestFixture]
    public class StarportBuilderTests {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void BuildHavingNoSystemThrows() {
            StarportBuilder builder = new StarportBuilder("Name", null);

            builder.Build();
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void BuildHavingNoName() {
            StarportBuilder builder = new StarportBuilder(" ", null);

            builder.Build();
        }

        [Test]
        public void BuildShouldBuildNowStarport() {
            string name = "McKay Port";
            StarportBuilder builder = new StarportBuilder(name, SolarSystems.Daibara);
            
            Starport mcKayPort = builder.Build();

            Assert.AreEqual(name, mcKayPort.Name);
            Assert.AreEqual(SolarSystems.Daibara, mcKayPort.System);
            Assert.AreEqual(1, mcKayPort.Version);
        }
    }
}
