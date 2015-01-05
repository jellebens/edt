using System.Data.Entity.Migrations;

namespace Sharpsolutions.Edt.Data.Migrations
{

    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "trade.Category",
                c => new
                    {
                        Id = c.Guid(false, true, null, "NEWID()"),
                        Name = c.String(false, 50)
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "trade.Commodity",
                c => new
                    {
                        Id = c.Guid(false, true, null, "NEWID()"),
                        Name = c.String(false, 50),
                        CategoryId = c.Guid(false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("trade.Category", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down(){
            DropForeignKey("trade.Commodity", "CategoryId", "trade.Category");
            DropIndex("trade.Commodity", new[] { "CategoryId" });
            DropTable("trade.Commodity");
            DropTable("trade.Category");
        }
    }
}
