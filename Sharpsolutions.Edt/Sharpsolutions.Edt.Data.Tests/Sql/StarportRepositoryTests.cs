using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Castle.Core.Logging;
using NUnit.Framework;
using Sharpsolutions.Edt.Data.Azure;
using Sharpsolutions.Edt.Data.Sql;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Data.Tests.Azure {
    [TestFixture]
    public class StarportRepositoryTests
    {
        private EdtDbContext _Context;
        private StarportRepository _repository;
        private CommodityRepository _commodityRepository;

        [SetUp]
        public void Setup()
        {
            _Context = new EdtDbContext("default");
            _repository =  new StarportRepository(_Context, new ConsoleFactory());
            _commodityRepository = new CommodityRepository(_Context, new ConsoleFactory());

        }

        [TearDown]
        public void TearDown()
        {
            _repository.Dispose();
            _commodityRepository.Dispose();
            _Context.Dispose();
        }

        [Test]
        public void AddHAvingAValidStarportShouldAdd()
        {
            
            Economy hightech = _repository.Get<Economy>(Economy.HighTech.Value); 
            StarportBuilder builder = new StarportBuilder(Guid.NewGuid().ToString(), "TEST", hightech, _commodityRepository.Query().ToList().AsQueryable());

            Starport starport = builder.Build();
            
            
            _repository.Add(starport);

            _repository.Commit();
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
            Starport starport = _repository.Query()
                .Include(x => x.Goods.Select(g => g.Commodity.Category))
                .First(x => x.System.Name == "TEST");
            
            Assert.IsNotNull(starport);

            foreach (StockItem good in starport.Goods)
            {
                Console.WriteLine(good.Commodity.Name);
                Console.WriteLine(good.Commodity.Category.Name);
            }

        }
    }
    


}
