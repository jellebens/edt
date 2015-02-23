using System.Data.Entity.Migrations;

namespace Sharpsolutions.Edt.Data.Migrations
{

	public partial class AddUniqueConstraintsOnStarPort : DbMigration
    {
        public override void Up()
        {
			CreateIndex("trade.Starport", "Name", true, "UC_Name");
			CreateIndex("trade.SolarSystem", "Name", true, "UC_Name");
		}
        
        public override void Down()
        {
            DropIndex("trade.Starport", "UC_Name");
			DropIndex("trade.SolarSystem", "UC_Name");
		}
    }
}
