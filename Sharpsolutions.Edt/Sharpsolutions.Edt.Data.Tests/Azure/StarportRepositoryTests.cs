﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sharpsolutions.Edt.Data.Azure;
using Sharpsolutions.Edt.Domain.Tests.Fakes;
using Sharpsolutions.Edt.Domain.Tests.Trade.Fakes;
using Sharpsolutions.Edt.Domain.Trade;
using Sharpsolutions.Edt.System.UnitTests.Azure;

namespace Sharpsolutions.Edt.Data.Tests.Azure {
    [TestFixture]
    public class StarportRepositoryTests {
        private readonly StarportRepository _repository = new StarportRepository();

        [TestFixtureSetUp]
        public void FixtureSetup() {
            Emulator.Start();
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
        [Ignore("Ignored due to refactoring in progress")]
        public void GetShouldGet()
        {
            Assert.Fail();
        }
    }
}
