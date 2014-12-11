using System.Data.Entity.Migrations;
using Sharpsolutions.Edt.Data.Sql.Mappings;

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
                        DisplayName = c.String(false, 15),
                    })
                .Index(t => t.DisplayName, "UC_Name", true)
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "trade.SolarSystem",
                c => new
                    {
                        Id = c.UniqueIdentifier(),
                        Name = c.String(false, 50),
                    })
                .Index(t => t.Name, "UC_Name", true)
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "trade.Starport",
                c => new
                    {
                        Id = c.UniqueIdentifier(),
                        Name = c.String(false, 50),
                        EconomyId = c.Int(false),
                        SolarSystemId = c.Guid(false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("trade.Economy", t => t.EconomyId)
                .ForeignKey("trade.SolarSystem", t => t.SolarSystemId)
                .Index(t => t.Name, "UC_Name", true)
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
                .PrimaryKey(t => new {t.CommodityId, t.StarportId})
                .ForeignKey("trade.Commodity", t => t.CommodityId, true)
                .ForeignKey("trade.Starport", t => t.StarportId, true)

                .Index(t => t.CommodityId)
                .Index(t => t.StarportId);
            
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
