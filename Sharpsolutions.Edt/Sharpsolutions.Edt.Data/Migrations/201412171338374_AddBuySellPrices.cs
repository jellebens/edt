using System.Data.Entity.Migrations;

namespace Sharpsolutions.Edt.Data.Migrations
{
    
    
    public partial class AddBuySellPrices : DbMigration
    {
        public override void Up()
        {
            AddColumn("trade.StarportCommodities", "Sell", c => c.Int(true));
            AddColumn("trade.StarportCommodities", "Buy", c => c.Int(true));
        }
        
        public override void Down()
        {
            DropColumn("trade.StarportCommodities", "Buy");
            DropColumn("trade.StarportCommodities", "Sell");
        }
    }
}
