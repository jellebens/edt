namespace Sharpsolutions.Edt.Domain.Trade
{
    public class IndustrialBuilder : StarportBuilderBase
    {
        protected override void AddGoods(Starport starport) {
           starport.Add(GetCommodity("Pesticides"), false, false);
           starport.Add(GetCommodity("Agricultural Medicines"), false, false);
           starport.Add(GetCommodity("Hydrogen Fuel"), false, true);
           starport.Add(GetCommodity("Explosives"), false, false);
           starport.Add(GetCommodity("Mineral Oil"), false, false);
           starport.Add(GetCommodity("Consumer Technology"), false, true);
           starport.Add(GetCommodity("Clothing"), true, true);
           starport.Add(GetCommodity("Domestic Appliances"), true, true);
           starport.Add(GetCommodity("Basic Narcotics"), false, false);
           starport.Add(GetCommodity("Beer"), false, false);
           starport.Add(GetCommodity("Wine"), false, false);
           starport.Add(GetCommodity("Liquor"), false, false);
           starport.Add(GetCommodity("Tobacco"), false, false);
           starport.Add(GetCommodity("Animal Meat"), false, true);
           starport.Add(GetCommodity("Coffee"), false, true);
           starport.Add(GetCommodity("Fish"), false, true);
           starport.Add(GetCommodity("Fruit"), false, true);
           starport.Add(GetCommodity("Grain"), false, true);
           starport.Add(GetCommodity("Tea"), false, true);
           starport.Add(GetCommodity("Synthetic Meat"), false, true);
           starport.Add(GetCommodity("Food Cartridges"), true, true);
           starport.Add(GetCommodity("Algae"), false, true);
           starport.Add(GetCommodity("Polymers"), false, true);
           starport.Add(GetCommodity("Semiconductors"), false, true);
           starport.Add(GetCommodity("Superconductors"), false, true);
           starport.Add(GetCommodity("Marine Supplies"), true, false);
           starport.Add(GetCommodity("Crop Harvesters"), true, false);
           starport.Add(GetCommodity("Mineral Extractors"), true, false);
           starport.Add(GetCommodity("Heliostatic Furnaces"), true, false);
           starport.Add(GetCommodity("Basic Medicines"), true, true);
           starport.Add(GetCommodity("Progenitor Cells"), false, true);
           starport.Add(GetCommodity("Combat Stabilisers"), false, false);
           starport.Add(GetCommodity("Performance Enhancers"), false, false);
           starport.Add(GetCommodity("Palladium"), false, false);
           starport.Add(GetCommodity("Silver"), false, false);
           starport.Add(GetCommodity("Gold"), false, true);
           starport.Add(GetCommodity("Copper"), false, true);
           starport.Add(GetCommodity("Alaminium"), false, true);
           starport.Add(GetCommodity("Beryllium"), false, true);
           starport.Add(GetCommodity("Indium"), false, true);
           starport.Add(GetCommodity("Lithium"), false, true);
           starport.Add(GetCommodity("Tantalum"), false, true);
           starport.Add(GetCommodity("Titanium"), false, true);
           starport.Add(GetCommodity("Uranium"), false, true);
           starport.Add(GetCommodity("Gallium"), false, true);
           starport.Add(GetCommodity("Lepidolite"), false, false);
           starport.Add(GetCommodity("Cobalt"), false, false);
           starport.Add(GetCommodity("Gallite"), false, false);
           starport.Add(GetCommodity("Indite"), false, false);
           starport.Add(GetCommodity("Uraninite"), false, false);
           starport.Add(GetCommodity("Bertrandite"), false, false);
           starport.Add(GetCommodity("Coltan"), false, false);
           starport.Add(GetCommodity("Bauxite"), false, false);
           starport.Add(GetCommodity("Rutile"), false, false);
           starport.Add(GetCommodity("HE Suits"), false, true);
           starport.Add(GetCommodity("Bio Reducing Lichen"), false, false);
           starport.Add(GetCommodity("Advanced Catalysers"), false, false);
           starport.Add(GetCommodity("Resonating Separators"), false, false);
           starport.Add(GetCommodity("Animal Monitors"), false, false);
           starport.Add(GetCommodity("Aquaponic Systems"), false, false);
           starport.Add(GetCommodity("Terrain Enrichment Systems"), false, false);
           starport.Add(GetCommodity("Auto Fabricators"), false, true);
           starport.Add(GetCommodity("Robotics"), false, true);
           starport.Add(GetCommodity("Computer Components"), true, false);
           starport.Add(GetCommodity("Leather"), false, true);
           starport.Add(GetCommodity("Natural Fabrics"), false, true);
           starport.Add(GetCommodity("Synthetic Fabrics"), false, true);
           starport.Add(GetCommodity("Biowaste"), true, false);
           starport.Add(GetCommodity("Scrap"), true, false);
           starport.Add(GetCommodity("Battle Weapons"), false, false);
           starport.Add(GetCommodity("Personal Weapons"), false, false);
           starport.Add(GetCommodity("Reactive Armour"), false, false);
           starport.Add(GetCommodity("Non-Lethal Weapons"), false, true);
        }
    }
}