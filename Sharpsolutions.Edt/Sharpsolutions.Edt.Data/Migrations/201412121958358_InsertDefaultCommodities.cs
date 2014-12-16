using System.Data.Entity.Migrations;
using System.Data.SqlClient;

namespace Sharpsolutions.Edt.Data.Migrations
{
   
    public partial class InsertDefaultCommodities : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT [Trade].[Category] ([Id], [Name]) VALUES (N'af3d97f2-3882-e411-8286-40167ead2fa4', N'Chemicals')");
            Sql("INSERT [Trade].[Category] ([Id], [Name]) VALUES (N'b53d97f2-3882-e411-8286-40167ead2fa4', N'Consumer Items')");
            Sql("INSERT [Trade].[Category] ([Id], [Name]) VALUES (N'b93d97f2-3882-e411-8286-40167ead2fa4', N'Drugs')");
            Sql("INSERT [Trade].[Category] ([Id], [Name]) VALUES (N'bf3d97f2-3882-e411-8286-40167ead2fa4', N'Foods')");
            Sql("INSERT [Trade].[Category] ([Id], [Name]) VALUES (N'c93d97f2-3882-e411-8286-40167ead2fa4', N'Industrial Materials')");
            Sql("INSERT [Trade].[Category] ([Id], [Name]) VALUES (N'cd3d97f2-3882-e411-8286-40167ead2fa4', N'Machinery')");
            Sql("INSERT [Trade].[Category] ([Id], [Name]) VALUES (N'd23d97f2-3882-e411-8286-40167ead2fa4', N'Medicines')");
            Sql("INSERT [Trade].[Category] ([Id], [Name]) VALUES (N'd73d97f2-3882-e411-8286-40167ead2fa4', N'Metals')");
            Sql("INSERT [Trade].[Category] ([Id], [Name]) VALUES (N'e33d97f2-3882-e411-8286-40167ead2fa4', N'Minerals')");
            Sql("INSERT [Trade].[Category] ([Id], [Name]) VALUES (N'ee3d97f2-3882-e411-8286-40167ead2fa4', N'Technology')");
            Sql("INSERT [Trade].[Category] ([Id], [Name]) VALUES (N'f93d97f2-3882-e411-8286-40167ead2fa4', N'Textiles')");
            Sql("INSERT [Trade].[Category] ([Id], [Name]) VALUES (N'fd3d97f2-3882-e411-8286-40167ead2fa4', N'Waste')");
            Sql("INSERT [Trade].[Category] ([Id], [Name]) VALUES (N'003e97f2-3882-e411-8286-40167ead2fa4', N'Weapons')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'b03d97f2-3882-e411-8286-40167ead2fa4', N'Pesticides', N'af3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'b13d97f2-3882-e411-8286-40167ead2fa4', N'Agricultural Medicines', N'af3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'b23d97f2-3882-e411-8286-40167ead2fa4', N'Hydrogen Fuel', N'af3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'b33d97f2-3882-e411-8286-40167ead2fa4', N'Explosives', N'af3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'b43d97f2-3882-e411-8286-40167ead2fa4', N'Mineral Oil', N'af3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'b63d97f2-3882-e411-8286-40167ead2fa4', N'Consumer Technology', N'b53d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'b73d97f2-3882-e411-8286-40167ead2fa4', N'Clothing', N'b53d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'b83d97f2-3882-e411-8286-40167ead2fa4', N'Domestic Appliances', N'b53d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'ba3d97f2-3882-e411-8286-40167ead2fa4', N'Basic Narcotics', N'b93d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'bb3d97f2-3882-e411-8286-40167ead2fa4', N'Beer', N'b93d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'bc3d97f2-3882-e411-8286-40167ead2fa4', N'Wine', N'b93d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'bd3d97f2-3882-e411-8286-40167ead2fa4', N'Liquor', N'b93d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'be3d97f2-3882-e411-8286-40167ead2fa4', N'Tobacco', N'b93d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'c03d97f2-3882-e411-8286-40167ead2fa4', N'Animal Meat', N'bf3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'c13d97f2-3882-e411-8286-40167ead2fa4', N'Coffee', N'bf3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'c23d97f2-3882-e411-8286-40167ead2fa4', N'Fish', N'bf3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'c33d97f2-3882-e411-8286-40167ead2fa4', N'Fruit', N'bf3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'c43d97f2-3882-e411-8286-40167ead2fa4', N'Grain', N'bf3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'c53d97f2-3882-e411-8286-40167ead2fa4', N'Tea', N'bf3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'c63d97f2-3882-e411-8286-40167ead2fa4', N'Synthetic Meat', N'bf3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'c73d97f2-3882-e411-8286-40167ead2fa4', N'Food Cartridges', N'bf3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'c83d97f2-3882-e411-8286-40167ead2fa4', N'Algae', N'bf3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'ca3d97f2-3882-e411-8286-40167ead2fa4', N'Polymers', N'c93d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'cb3d97f2-3882-e411-8286-40167ead2fa4', N'Semiconductors', N'c93d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'cc3d97f2-3882-e411-8286-40167ead2fa4', N'Superconductors', N'c93d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'ce3d97f2-3882-e411-8286-40167ead2fa4', N'Marine Supplies', N'cd3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'cf3d97f2-3882-e411-8286-40167ead2fa4', N'Crop Harvesters', N'cd3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'd03d97f2-3882-e411-8286-40167ead2fa4', N'Mineral Extractors', N'cd3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'd13d97f2-3882-e411-8286-40167ead2fa4', N'Heliostatic Furnaces', N'cd3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'd33d97f2-3882-e411-8286-40167ead2fa4', N'Basic Medicines', N'd23d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'd43d97f2-3882-e411-8286-40167ead2fa4', N'Progenitor Cells', N'd23d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'd53d97f2-3882-e411-8286-40167ead2fa4', N'Combat Stabilisers', N'd23d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'd63d97f2-3882-e411-8286-40167ead2fa4', N'Performance Enhancers', N'd23d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'd83d97f2-3882-e411-8286-40167ead2fa4', N'Palladium', N'd73d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'd93d97f2-3882-e411-8286-40167ead2fa4', N'Silver', N'd73d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'da3d97f2-3882-e411-8286-40167ead2fa4', N'Gold', N'd73d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'db3d97f2-3882-e411-8286-40167ead2fa4', N'Copper', N'd73d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'dc3d97f2-3882-e411-8286-40167ead2fa4', N'Alaminium', N'd73d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'dd3d97f2-3882-e411-8286-40167ead2fa4', N'Beryllium', N'd73d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'de3d97f2-3882-e411-8286-40167ead2fa4', N'Indium', N'd73d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'df3d97f2-3882-e411-8286-40167ead2fa4', N'Lithium', N'd73d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'e03d97f2-3882-e411-8286-40167ead2fa4', N'Tantalum', N'd73d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'e13d97f2-3882-e411-8286-40167ead2fa4', N'Titanium', N'd73d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'e23d97f2-3882-e411-8286-40167ead2fa4', N'Uranium', N'd73d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'e43d97f2-3882-e411-8286-40167ead2fa4', N'Gallium', N'e33d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'e53d97f2-3882-e411-8286-40167ead2fa4', N'Lepidolite', N'e33d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'e63d97f2-3882-e411-8286-40167ead2fa4', N'Cobalt', N'e33d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'e73d97f2-3882-e411-8286-40167ead2fa4', N'Gallite', N'e33d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'e83d97f2-3882-e411-8286-40167ead2fa4', N'Indite', N'e33d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'e93d97f2-3882-e411-8286-40167ead2fa4', N'Uraninite', N'e33d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'ea3d97f2-3882-e411-8286-40167ead2fa4', N'Bertrandite', N'e33d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'eb3d97f2-3882-e411-8286-40167ead2fa4', N'Coltan', N'e33d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'ec3d97f2-3882-e411-8286-40167ead2fa4', N'Bauxite', N'e33d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'ed3d97f2-3882-e411-8286-40167ead2fa4', N'Rutile', N'e33d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'ef3d97f2-3882-e411-8286-40167ead2fa4', N'HE Suits', N'ee3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'f03d97f2-3882-e411-8286-40167ead2fa4', N'Bio Reducing Lichen', N'ee3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'f13d97f2-3882-e411-8286-40167ead2fa4', N'Advanced Catalysers', N'ee3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'f23d97f2-3882-e411-8286-40167ead2fa4', N'Resonating Separators', N'ee3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'f33d97f2-3882-e411-8286-40167ead2fa4', N'Animal Monitors', N'ee3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'f43d97f2-3882-e411-8286-40167ead2fa4', N'Aquaponic Systems', N'ee3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'f53d97f2-3882-e411-8286-40167ead2fa4', N'Terrain Enrichment Systems', N'ee3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'f63d97f2-3882-e411-8286-40167ead2fa4', N'Auto Fabricators', N'ee3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'f73d97f2-3882-e411-8286-40167ead2fa4', N'Robotics', N'ee3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'f83d97f2-3882-e411-8286-40167ead2fa4', N'Computer Components', N'ee3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'fa3d97f2-3882-e411-8286-40167ead2fa4', N'Leather', N'f93d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'fb3d97f2-3882-e411-8286-40167ead2fa4', N'Natural Fabrics', N'f93d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'fc3d97f2-3882-e411-8286-40167ead2fa4', N'Synthetic Fabrics', N'f93d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'fe3d97f2-3882-e411-8286-40167ead2fa4', N'Biowaste', N'fd3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'ff3d97f2-3882-e411-8286-40167ead2fa4', N'Scrap', N'fd3d97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'013e97f2-3882-e411-8286-40167ead2fa4', N'Battle Weapons', N'003e97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'023e97f2-3882-e411-8286-40167ead2fa4', N'Personal Weapons', N'003e97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'033e97f2-3882-e411-8286-40167ead2fa4', N'Reactive Armour', N'003e97f2-3882-e411-8286-40167ead2fa4')");
            Sql("INSERT [Trade].[Commodity] ([Id], [Name], [CategoryId]) VALUES (N'043e97f2-3882-e411-8286-40167ead2fa4', N'Non-Lethal Weapons', N'003e97f2-3882-e411-8286-40167ead2fa4')");

        }
        
        public override void Down()
        {
            Sql("DELETE FROM trade.Commodity");
            Sql("DELETE FROM trade.Category");
        }
    }
}
