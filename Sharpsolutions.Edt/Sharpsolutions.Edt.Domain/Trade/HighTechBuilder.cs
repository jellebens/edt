namespace Sharpsolutions.Edt.Domain.Trade
{
    public class HighTechBuilder : StarportBuilderBase
    {
        protected override void AddGoods(Starport starport)
        {
            starport.Add(GetCommodity("Pesticides"), true, false);
            starport.Add(GetCommodity("Agricultural Medicines"), true, false);
            starport.Add(GetCommodity("Hydrogen Fuel"), false, true);
            starport.Add(GetCommodity("Explosives"), false, false);
            starport.Add(GetCommodity("Mineral Oil"), false, false);
            starport.Add(GetCommodity("Consumer Technology"), true, true);
            starport.Add(GetCommodity("Clothing"), false, true);
            starport.Add(GetCommodity("Domestic Appliances"), false, true);
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
            starport.Add(GetCommodity("Synthetic Meat"), true, true);
            starport.Add(GetCommodity("Food Cartridges"), false, true);
            starport.Add(GetCommodity("Algae"), false, false);
            starport.Add(GetCommodity("Polymers"), false, false);
            starport.Add(GetCommodity("Semiconductors"), false, false);
            starport.Add(GetCommodity("Superconductors"), false, true);
            starport.Add(GetCommodity("Marine Supplies"), false, false);
            starport.Add(GetCommodity("Crop Harvesters"), false, false);
            starport.Add(GetCommodity("Mineral Extractors"), false, false);
            starport.Add(GetCommodity("Heliostatic Furnaces"), false, true);
            starport.Add(GetCommodity("Basic Medicines"), false, true);
            starport.Add(GetCommodity("Progenitor Cells"), true, false);
            starport.Add(GetCommodity("Combat Stabilisers"), true, false);
            starport.Add(GetCommodity("Performance Enhancers"), true, false);
            starport.Add(GetCommodity("Palladium"), false, true);
            starport.Add(GetCommodity("Silver"), false, true);
            starport.Add(GetCommodity("Gold"), false, true);
            starport.Add(GetCommodity("Copper"), false, false);
            starport.Add(GetCommodity("Alaminium"), false, false);
            starport.Add(GetCommodity("Beryllium"), false, false);
            starport.Add(GetCommodity("Indium"), false, true);
            starport.Add(GetCommodity("Lithium"), false, true);
            starport.Add(GetCommodity("Tantalum"), false, true);
            starport.Add(GetCommodity("Titanium"), false, true);
            starport.Add(GetCommodity("Uranium"), false, true);
            starport.Add(GetCommodity("Gallium"), false, true);
            starport.Add(GetCommodity("Lepidolite"), false, true);
            starport.Add(GetCommodity("Cobalt"), false, true);
            starport.Add(GetCommodity("Gallite"), false, true);
            starport.Add(GetCommodity("Indite"), false, false);
            starport.Add(GetCommodity("Uraninite"), false, false);
            starport.Add(GetCommodity("Bertrandite"), false, false);
            starport.Add(GetCommodity("Coltan"), false, false);
            starport.Add(GetCommodity("Bauxite"), false, false);
            starport.Add(GetCommodity("Rutile"), false, false);
            starport.Add(GetCommodity("HE Suits"), true, true);
            starport.Add(GetCommodity("Bio Reducing Lichen"), true, false);
            starport.Add(GetCommodity("Advanced Catalysers"), true, false);
            starport.Add(GetCommodity("Resonating Separators"), true, false);
            starport.Add(GetCommodity("Animal Monitors"), true, false);
            starport.Add(GetCommodity("Aquaponic Systems"), true, false);
            starport.Add(GetCommodity("Terrain Enrichment Systems"), true, false);
            starport.Add(GetCommodity("Auto Fabricators"), true, false);
            starport.Add(GetCommodity("Robotics"), true, false);
            starport.Add(GetCommodity("Computer Components"), false, true);
            starport.Add(GetCommodity("Leather"), false, false);
            starport.Add(GetCommodity("Natural Fabrics"), false, false);
            starport.Add(GetCommodity("Synthetic Fabrics"), false, false);
            starport.Add(GetCommodity("Biowaste"), true, false);
            starport.Add(GetCommodity("Scrap"), true, false);
            starport.Add(GetCommodity("Battle Weapons"), false, false);
            starport.Add(GetCommodity("Personal Weapons"), false, false);
            starport.Add(GetCommodity("Reactive Armour"), true, false);
            starport.Add(GetCommodity("Non-Lethal Weapons"), true, true);
        }
    }
}