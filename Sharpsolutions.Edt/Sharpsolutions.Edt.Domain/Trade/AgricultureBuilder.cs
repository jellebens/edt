namespace Sharpsolutions.Edt.Domain.Trade
{
    public class AgricultureBuilder : StarportBuilderBase {
        protected override void AddGoods(Starport starport) {
            starport.Add("Pesticides", "Chemicals", false, true);
            starport.Add("Agricultural Medicines", "Chemicals", false, true);
            starport.Add("Hydrogen Fuel", "Chemicals", false, true);
            starport.Add("Explosives", "Chemicals", false, false);
            starport.Add("Mineral Oil", "Chemicals", true, false);
            starport.Add("Consumer Technology", "Consumer Items", false, true);
            starport.Add("Clothing", "Consumer Items", false, true);
            starport.Add("Domestic Appliances", "Consumer Items", false, true);
            starport.Add("Basic Narcotics", "Drugs", false, false);
            starport.Add("Beer", "Drugs", false, false);
            starport.Add("Wine", "Drugs", false, false);
            starport.Add("Liquor", "Drugs", true, false);
            starport.Add("Tobacco", "Drugs", true, false);
            starport.Add("Animal Meat", "Foods", true, true);
            starport.Add("Coffee", "Foods", true, true);
            starport.Add("Fish", "Foods", true, true);
            starport.Add("Fruit", "Foods", true, true);
            starport.Add("Grain", "Foods", true, true);
            starport.Add("Tea", "Foods", true, true);
            starport.Add("Synthetic Meat", "Foods", false, false);
            starport.Add("Food Cartridges", "Foods", false, false);
            starport.Add("Algae", "Foods", true, false);
            starport.Add("Polymers", "Industrial Materials", false, false);
            starport.Add("Semiconductors", "Industrial Materials", false, false);
            starport.Add("Superconductors", "Industrial Materials", false, false);
            starport.Add("Marine Supplies", "Machinery", false, true);
            starport.Add("Crop Harvesters", "Machinery", false, true);
            starport.Add("Mineral Extractors", "Machinery", false, false);
            starport.Add("Heliostatic Furnaces", "Machinery", false, false);
            starport.Add("Basic Medicines", "Medicines", false, true);
            starport.Add("Progenitor Cells", "Medicines", false, true);
            starport.Add("Combat Stabilisers", "Medicines", false, false);
            starport.Add("Performance Enhancers", "Medicines", false, false);
            starport.Add("Palladium", "Metals", false, false);
            starport.Add("Silver", "Metals", false, false);
            starport.Add("Gold", "Metals", false, false);
            starport.Add("Copper", "Metals", false, false);
            starport.Add("Alaminium", "Metals", false, false);
            starport.Add("Beryllium", "Metals", false, false);
            starport.Add("Indium", "Metals", false, false);
            starport.Add("Lithium", "Metals", false, false);
            starport.Add("Tantalum", "Metals", false, false);
            starport.Add("Titanium", "Metals", false, false);
            starport.Add("Uranium", "Metals", false, false);
            starport.Add("Gallium", "Minerals", false, false);
            starport.Add("Lepidolite", "Minerals", false, false);
            starport.Add("Cobalt", "Minerals", false, false);
            starport.Add("Gallite", "Minerals", false, false);
            starport.Add("Indite", "Minerals", false, false);
            starport.Add("Uraninite", "Minerals", false, false);
            starport.Add("Bertrandite", "Minerals", false, false);
            starport.Add("Coltan", "Minerals", false, false);
            starport.Add("Bauxite", "Minerals", false, false);
            starport.Add("Rutile", "Minerals", false, false);
            starport.Add("HE Suits", "Technology", false, false);
            starport.Add("Bio Reducing Lichen", "Technology", false, false);
            starport.Add("Advanced Catalysers", "Technology", false, false);
            starport.Add("Resonating Separators", "Technology", false, false);
            starport.Add("Animal Monitors", "Technology", false, true);
            starport.Add("Aquaponic Systems", "Technology", false, true);
            starport.Add("Terrain Enrichment Systems", "Technology", false, true);
            starport.Add("Auto Fabricators", "Technology", false, false);
            starport.Add("Robotics", "Technology", false, false);
            starport.Add("Computer Components", "Technology", false, false);
            starport.Add("Leather", "Textiles", true, false);
            starport.Add("Natural Fabrics", "Textiles", true, false);
            starport.Add("Synthetic Fabrics", "Textiles", false, false);
            starport.Add("Biowaste", "Waste", true, true);
            starport.Add("Scrap", "Waste", false, false);
            starport.Add("Battle Weapons", "Weapons", false, false);
            starport.Add("Personal Weapons", "Weapons", false, false);
            starport.Add("Reactive Armour", "Weapons", false, false);
            starport.Add("Non-Lethal Weapons", "Weapons", false, true);

        }
    }
}