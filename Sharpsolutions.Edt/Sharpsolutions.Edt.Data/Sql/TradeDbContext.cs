using System.Data.Entity;
using Sharpsolutions.Edt.Data.Migrations;
using Sharpsolutions.Edt.Data.Sql.Mappings;

namespace Sharpsolutions.Edt.Data.Sql {
    public class TradeDbContext: DbContext {

        public TradeDbContext(): this("default")
        {
            
        }

        public TradeDbContext(string nameOrConnectionString)
        {
            Database.SetInitializer<TradeDbContext>(new MigrateDatabaseToLatestVersion<TradeDbContext, TradeMigrationsConfiguration>(nameOrConnectionString));
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Configurations.AddFromAssembly(typeof(Mapping).Assembly);
        }
    }
}
