using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sharpsolutions.Edt.Data.Azure;
using Sharpsolutions.Edt.Domain.Tests.Fakes;
using Sharpsolutions.Edt.Domain.Tests.Trade.Fakes;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Data.Tests.Azure {
    [TestFixture]
    public class StarportRepositoryTests {
        private readonly StarportRepository _repository = new StarportRepository();

        [TestFixtureSetUp]
        public void FixtureSetup() {
            new Emulator();
            _repository.Init();
        }

        [Test]
        public void AddShouldNotThrow()
        {
            StarportBuilder builder = new StarportBuilder(Guid.NewGuid().ToString(), SolarSystems.Daibara);
            Starport random = builder.Build();

            _repository.CommitChanges(random);
        }

        [Test]
        public void GetShouldGet()
        {
            Assert.Fail();
        }
    }
}
