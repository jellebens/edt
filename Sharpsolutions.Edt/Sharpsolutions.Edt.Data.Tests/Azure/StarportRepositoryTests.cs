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
    public class StarportRepositoryTests
    {
        private readonly StarportRepository _repository = new StarportRepository();

        [Test]
        public void AddHAvingAValidStarportShouldAdd()
        {
            StarportBuilder builder = new StarportBuilder(Guid.NewGuid().ToString(), "TEST", Economy.HighTech);

            Starport starport = builder.Build();

            _repository.Add(starport);
        }

        [Test]
        public void QueryShouldRetrieveAllEntities()
        {
            IEnumerable<Starport> all = _repository.Query();

            Assert.AreNotEqual(0, all.Count());
        }

        [Test]
        public void GetHavingValueShouldNotBeNull()
        {
            var x = _repository.Get("test");

            Assert.IsNotNull(x);
        }
    }
    


}
