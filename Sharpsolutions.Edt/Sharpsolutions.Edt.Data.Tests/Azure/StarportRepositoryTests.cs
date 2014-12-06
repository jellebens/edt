using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sharpsolutions.Edt.Data.Azure;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Data.Tests.Azure {
    [TestFixture]
    public class StarportRepositoryTests {
        private readonly StarportRepository _repository = new StarportRepository();

        [Test]
        public void AddHAvingAValidStarportShouldAdd()
        {
            StarportBuilder builder = new StarportBuilder(Guid.NewGuid().ToString(), "Sol", Economy.HighTech);

            Starport starport = builder.Build();

            _repository.Add(starport);
        }
    }
}
