using System.Data.Entity.Migrations;

namespace Sharpsolutions.Edt.Data.Migrations
{
    public partial class AddIsInRangeProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("trade.Starport", "IsInRange", c => c.Boolean(false, false));
        }
        
        public override void Down()
        {
            DropColumn("trade.Starport", "IsInRange");
        }
    }
}
