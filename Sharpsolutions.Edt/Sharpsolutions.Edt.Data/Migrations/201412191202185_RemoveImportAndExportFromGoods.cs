using System.Data.Entity.Migrations;

namespace Sharpsolutions.Edt.Data.Migrations
{ 
    public partial class RemoveImportAndExportFromGoods : DbMigration
    {
        public override void Up()
        {
            DropColumn("trade.StarportCommodities", "Exports");
            DropColumn("trade.StarportCommodities", "Imports");
        }
        
        public override void Down()
        {
            AddColumn("trade.StarportCommodities", "Imports", c => c.Boolean(false, false));
            AddColumn("trade.StarportCommodities", "Exports", c => c.Boolean(false, false));
        }
    }
}
