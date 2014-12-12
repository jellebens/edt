using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Domain.Tests.Trade {
    public class FakeCommodities
    {
        public static Commodity Silver = Commodity.CommodityFactory.Create("Silver", new Category("Metals"));
        public static Commodity Pesticides = Commodity.CommodityFactory.Create("Pesticides", new Category("Chemicals"));
        public static Commodity Biowaste = Commodity.CommodityFactory.Create("Biowaste", new Category("Waste"));
        public static Commodity Clothing = Commodity.CommodityFactory.Create("Clothing", new Category("Consumer Items"));

        private List<Commodity> _commodities = new List<Commodity>();

        public FakeCommodities()
        {
            this.Add("Pesticides", "Chemicals");
            this.Add("Agricultural Medicines", "Chemicals");
            this.Add("Hydrogen Fuel", "Chemicals");
            this.Add("Explosives", "Chemicals");
            this.Add("Mineral Oil", "Chemicals");
            this.Add("Consumer Technology", "Consumer Items");
            this.Add("Clothing", "Consumer Items");
            this.Add("Domestic Appliances", "Consumer Items");
            this.Add("Basic Narcotics", "Drugs");
            this.Add("Beer", "Drugs");
            this.Add("Wine", "Drugs");
            this.Add("Liquor", "Drugs");
            this.Add("Tobacco", "Drugs");
            this.Add("Animal Meat", "Foods");
            this.Add("Coffee", "Foods");
            this.Add("Fish", "Foods");
            this.Add("Fruit", "Foods");
            this.Add("Grain", "Foods");
            this.Add("Tea", "Foods");
            this.Add("Synthetic Meat", "Foods");
            this.Add("Food Cartridges", "Foods");
            this.Add("Algae", "Foods");
            this.Add("Polymers", "Industrial Materials");
            this.Add("Semiconductors", "Industrial Materials");
            this.Add("Superconductors", "Industrial Materials");
            this.Add("Marine Supplies", "Machinery");
            this.Add("Crop Harvesters", "Machinery");
            this.Add("Mineral Extractors", "Machinery");
            this.Add("Heliostatic Furnaces", "Machinery");
            this.Add("Basic Medicines", "Medicines");
            this.Add("Progenitor Cells", "Medicines");
            this.Add("Combat Stabilisers", "Medicines");
            this.Add("Performance Enhancers", "Medicines");
            this.Add("Palladium", "Metals");
            this.Add("Silver", "Metals");
            this.Add("Gold", "Metals");
            this.Add("Copper", "Metals");
            this.Add("Alaminium", "Metals");
            this.Add("Beryllium", "Metals");
            this.Add("Indium", "Metals");
            this.Add("Lithium", "Metals");
            this.Add("Tantalum", "Metals");
            this.Add("Titanium", "Metals");
            this.Add("Uranium", "Metals");
            this.Add("Gallium", "Minerals");
            this.Add("Lepidolite", "Minerals");
            this.Add("Cobalt", "Minerals");
            this.Add("Gallite", "Minerals");
            this.Add("Indite", "Minerals");
            this.Add("Uraninite", "Minerals");
            this.Add("Bertrandite", "Minerals");
            this.Add("Coltan", "Minerals");
            this.Add("Bauxite", "Minerals");
            this.Add("Rutile", "Minerals");
            this.Add("HE Suits", "Technology");
            this.Add("Bio Reducing Lichen", "Technology");
            this.Add("Advanced Catalysers", "Technology");
            this.Add("Resonating Separators", "Technology");
            this.Add("Animal Monitors", "Technology");
            this.Add("Aquaponic Systems", "Technology");
            this.Add("Terrain Enrichment Systems", "Technology");
            this.Add("Auto Fabricators", "Technology");
            this.Add("Robotics", "Technology");
            this.Add("Computer Components", "Technology");
            this.Add("Leather", "Textiles");
            this.Add("Natural Fabrics", "Textiles");
            this.Add("Synthetic Fabrics", "Textiles");
            this.Add("Biowaste", "Waste");
            this.Add("Scrap", "Waste");
            this.Add("Battle Weapons", "Weapons");
            this.Add("Personal Weapons", "Weapons");
            this.Add("Reactive Armour", "Weapons");
            this.Add("Non-Lethal Weapons", "Weapons");
        }

        public void Add(string name, string category)
        {
            Commodity c = Commodity.CommodityFactory.Create(name, new Category(category));

            _commodities.Add(c);
        }

        public IQueryable<Commodity> AllCommodities()
        {
            return _commodities.AsQueryable();
        }

    }
}
