using System.Data.Entity.Migrations;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Data.Migrations
{
    
    
    public partial class AddStarports : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "trade.Economy",
                c => new
                    {
                        Id = c.Int(false),
                        Name = c.String(false, 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "trade.SolarSystem",
                c => new
                    {
                        Id = c.Guid(false, true),
                        Name = c.String(false, 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "trade.Starport",
                c => new
                    {
                        Id = c.Guid(false, true),
                        Name = c.String(false, 50),
                        EconomyId = c.Int(false),
                        SolarSystemId = c.Guid(false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("trade.Economy", t => t.EconomyId)
                .ForeignKey("trade.SolarSystem", t => t.SolarSystemId)
                .Index(t => t.EconomyId)
                .Index(t => t.SolarSystemId);
            
            CreateTable(
                "trade.StarportCommodities",
                c => new
                    {
                        RowId = c.Long(false, true),
                        Exports = c.Boolean(false),
                        Imports = c.Boolean(false),
                        CommodityId = c.Guid(false),
                        StarportId = c.Guid(false),
                    })
                .PrimaryKey(t => t.RowId)
                .ForeignKey("trade.Commodity", t => t.CommodityId, true)
                .ForeignKey("trade.Starport", t => t.StarportId, true)
                .Index(t => t.CommodityId)
                .Index(t => t.StarportId);

            foreach (Economy economy in Economy.All())
            {
                string sql = string.Format("INSERT INTO trade.Economy(Id, Name) VALUES({0}, '{1}')", economy.Value,
                    economy.DisplayName);

                Sql(sql);
            }
            
        }
        
        public override void Down()
        {
            DropForeignKey("trade.Starport", "SolarSystemId", "trade.SolarSystem");
            DropForeignKey("trade.StarportCommodities", "StarportId", "trade.Starport");
            DropForeignKey("trade.StarportCommodities", "CommodityId", "trade.Commodity");
            DropForeignKey("trade.Starport", "EconomyId", "trade.Economy");
            DropIndex("trade.StarportCommodities", new[] { "StarportId" });
            DropIndex("trade.StarportCommodities", new[] { "CommodityId" });
            DropIndex("trade.Starport", new[] { "SolarSystemId" });
            DropIndex("trade.Starport", new[] { "EconomyId" });
            DropTable("trade.StarportCommodities");
            DropTable("trade.Starport");
            DropTable("trade.SolarSystem");
            DropTable("trade.Economy");
        }
    }
}
