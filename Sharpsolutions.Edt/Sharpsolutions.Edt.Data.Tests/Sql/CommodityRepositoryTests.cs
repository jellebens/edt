using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sharpsolutions.Edt.Data.Migrations;
using Sharpsolutions.Edt.Data.Sql;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Data.Tests.Sql {
    [TestFixture]
    public class CommodityRepositoryTests {
        [Test]
        public void ListPendingMigrations() {
            DbMigrator migrator = new DbMigrator(new TradeMigrationsConfiguration());

            IEnumerable<string> changes = migrator.GetPendingMigrations();

            foreach (string change in changes) {
                Console.WriteLine(change);
            }
        }

        [Test]
        public void ExecutePendingMigrations()
        {
            using (TradeDbContext context = new TradeDbContext("default")) {
                context.Database.Log = Console.Write;

                foreach (Commodity c in context.Set<Commodity>())
                {
                    Console.Write("Commodity {0}", c.Name);
                }
            }
        }
    }
}
