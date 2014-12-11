using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;
using Sharpsolutions.Edt.Data.Sql.Mappings;

namespace Sharpsolutions.Edt.Data.Migrations
{
    
    
    public partial class AddUniqueConstraints : DbMigration
    {
        public override void Up()
        {
            CreateIndex("trade.Category", "Name", true, "UC_Name");
            CreateIndex("trade.Commodity", "Name", true, "UC_Name");
        }
        
        public override void Down()
        {
            DropIndex("trade.Category", "UC_Name");
            DropIndex("trade.Commodity", "UC_Name");
        }
    }
}
