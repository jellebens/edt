using System.Data.Entity.Migrations;
using System.Linq;
using Sharpsolutions.Edt.Data.Sql;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Data.Migrations
{
    
    internal sealed class Configuration : DbMigrationsConfiguration<EdtDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EdtDbContext context)
        {
            
 
        }
    }
}
