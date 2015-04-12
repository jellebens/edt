using System.Data.Entity.Migrations;
using Sharpsolutions.Edt.Data.Sql;

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
