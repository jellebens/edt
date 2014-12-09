using System.Data.Entity.Migrations;
using Sharpsolutions.Edt.Data.Sql;

namespace Sharpsolutions.Edt.Data.Migrations
{
    
    public sealed class TradeMigrationsConfiguration : DbMigrationsConfiguration<TradeDbContext>
    {
        public TradeMigrationsConfiguration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TradeDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
