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
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "trade.SolarSystem",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "trade.Starport",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        EconomyId = c.Int(nullable: false),
                        SolarSystemId = c.Guid(nullable: false),
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
                        RowId = c.Long(nullable: false, identity: true),
                        Exports = c.Boolean(nullable: false),
                        Imports = c.Boolean(nullable: false),
                        CommodityId = c.Guid(nullable: false),
                        StarportId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.RowId)
                .ForeignKey("trade.Commodity", t => t.CommodityId, cascadeDelete: true)
                .ForeignKey("trade.Starport", t => t.StarportId, cascadeDelete: true)
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
