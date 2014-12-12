namespace Sharpsolutions.Edt.Domain.Trade
{
    public class ExtractionBuilder : StarportBuilderBase
    {
        protected override void AddGoods(Starport starport)
        {
            starport.Add(GetCommodity("Pesticides"), false, false);
            starport.Add(GetCommodity("Agricultural Medicines"), false, false);
            starport.Add(GetCommodity("Hydrogen Fuel"), false, true);
            starport.Add(GetCommodity("Explosives"), false, true);
            starport.Add(GetCommodity("Mineral Oil"), false, false);
            starport.Add(GetCommodity("Consumer Technology"), false, true);
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
            starport.Add(GetCommodity("Synthetic Meat"), false, true);
            starport.Add(GetCommodity("Food Cartridges"), false, true);
            starport.Add(GetCommodity("Algae"), false, false);
            starport.Add(GetCommodity("Polymers"), false, false);
            starport.Add(GetCommodity("Semiconductors"), false, false);
            starport.Add(GetCommodity("Superconductors"), false, false);
            starport.Add(GetCommodity("Marine Supplies"), false, false);
            starport.Add(GetCommodity("Crop Harvesters"), false, false);
            starport.Add(GetCommodity("Mineral Extractors"), false, true);
            starport.Add(GetCommodity("Heliostatic Furnaces"), false, false);
            starport.Add(GetCommodity("Basic Medicines"), false, true);
            starport.Add(GetCommodity("Progenitor Cells"), false, false);
            starport.Add(GetCommodity("Combat Stabilisers"), false, false);
            starport.Add(GetCommodity("Performance Enhancers"), false, false);
            starport.Add(GetCommodity("Palladium"), true, false);
            starport.Add(GetCommodity("Silver"), true, false);
            starport.Add(GetCommodity("Gold"), true, false);
            starport.Add(GetCommodity("Copper"), false, false);
            starport.Add(GetCommodity("Alaminium"), false, false);
            starport.Add(GetCommodity("Beryllium"), false, false);
            starport.Add(GetCommodity("Indium"), false, false);
            starport.Add(GetCommodity("Lithium"), false, false);
            starport.Add(GetCommodity("Tantalum"), false, false);
            starport.Add(GetCommodity("Titanium"), false, false);
            starport.Add(GetCommodity("Uranium"), false, false);
            starport.Add(GetCommodity("Gallium"), false, false);
            starport.Add(GetCommodity("Lepidolite"), false, false);
            starport.Add(GetCommodity("Cobalt"), false, false);
            starport.Add(GetCommodity("Gallite"), true, false);
            starport.Add(GetCommodity("Indite"), true, false);
            starport.Add(GetCommodity("Uraninite"), true, false);
            starport.Add(GetCommodity("Bertrandite"), true, false);
            starport.Add(GetCommodity("Coltan"), true, false);
            starport.Add(GetCommodity("Bauxite"), true, false);
            starport.Add(GetCommodity("Rutile"), true, false);
            starport.Add(GetCommodity("HE Suits"), false, true);
            starport.Add(GetCommodity("Bio Reducing Lichen"), false, true);
            starport.Add(GetCommodity("Advanced Catalysers"), false, false);
            starport.Add(GetCommodity("Resonating Separators"), false, false);
            starport.Add(GetCommodity("Animal Monitors"), false, false);
            starport.Add(GetCommodity("Aquaponic Systems"), false, false);
            starport.Add(GetCommodity("Terrain Enrichment Systems"), false, false);
            starport.Add(GetCommodity("Auto Fabricators"), false, false);
            starport.Add(GetCommodity("Robotics"), false, false);
            starport.Add(GetCommodity("Computer Components"), false, false);
            starport.Add(GetCommodity("Leather"), false, false);
            starport.Add(GetCommodity("Natural Fabrics"), false, false);
            starport.Add(GetCommodity("Synthetic Fabrics"), false, false);
            starport.Add(GetCommodity("Biowaste"), true, false);
            starport.Add(GetCommodity("Scrap"), false, false);
            starport.Add(GetCommodity("Battle Weapons"), false, false);
            starport.Add(GetCommodity("Personal Weapons"), false, false);
            starport.Add(GetCommodity("Reactive Armour"), false, false);
            starport.Add(GetCommodity("Non-Lethal Weapons"), false, true);

        }
    }
}