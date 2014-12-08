using Microsoft.WindowsAzure.Storage;
using NUnit.Framework;
using Sharpsolutions.Edt.Data.Azure;
using Sharpsolutions.Edt.System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Data.Tests.Azure {
    [TestFixture]
    public class CommodityRepositoryTests {
        private IRepository<Commodity> _repository = new CommodityRepository();

        [Test]
        public void AddHavingACommodityShouldNotThrow() {
            string[] all = {"Pesticides,Chemicals",
                            "Agricultural Medicines,Chemicals",
                            "Hydrogen Fuel,Chemicals",
                            "Explosives,Chemicals",
                            "Mineral Oil,Chemicals",
                            "Consumer Technology,Consumer Items",
                            "Clothing,Consumer Items",
                            "Domestic Appliances,Consumer Items",
                            "Basic Narcotics,Drugs",
                            "Beer,Drugs",
                            "Wine,Drugs",
                            "Liquor,Drugs",
                            "Tobacco,Drugs",
                            "Animal Meat,Foods",
                            "Coffee,Foods",
                            "Fish,Foods",
                            "Fruit,Foods",
                            "Grain,Foods",
                            "Tea,Foods",
                            "Synthetic Meat,Foods",
                            "Food Cartridges,Foods",
                            "Algae,Foods",
                            "Polymers,Industrial Materials",
                            "Semiconductors,Industrial Materials",
                            "Superconductors,Industrial Materials",
                            "Marine Supplies,Machinery",
                            "Crop Harvesters,Machinery",
                            "Mineral Extractors,Machinery",
                            "Heliostatic Furnaces,Machinery",
                            "Basic Medicines,Medicines",
                            "Progenitor Cells,Medicines",
                            "Combat Stabilisers,Medicines",
                            "Performance Enhancers,Medicines",
                            "Palladium,Metals",
                            "Silver,Metals",
                            "Gold,Metals",
                            "Copper,Metals",
                            "Alaminium,Metals",
                            "Beryllium,Metals",
                            "Indium,Metals",
                            "Lithium,Metals",
                            "Tantalum,Metals",
                            "Titanium,Metals",
                            "Uranium,Metals",
                            "Gallium,Minerals",
                            "Lepidolite,Minerals",
                            "Cobalt,Minerals",
                            "Gallite,Minerals",
                            "Indite,Minerals",
                            "Uraninite,Minerals",
                            "Bertrandite,Minerals",
                            "Coltan,Minerals",
                            "Bauxite,Minerals",
                            "Rutile,Minerals",
                            "HE Suits,Technology",
                            "Bio Reducing Lichen,Technology",
                            "Advanced Catalysers,Technology",
                            "Resonating Separators,Technology",
                            "Animal Monitors,Technology",
                            "Aquaponic Systems,Technology",
                            "Terrain Enrichment Systems,Technology",
                            "Auto Fabricators,Technology",
                            "Robotics,Technology",
                            "Computer Components,Technology",
                            "Leather,Textiles",
                            "Natural Fabrics,Textiles",
                            "Synthetic Fabrics,Textiles",
                            "Biowaste,Waste",
                            "Scrap,Waste",
                            "Battle Weapons,Weapons",
                            "Personal Weapons,Weapons",
                            "Reactive Armour,Weapons",
                            "Non-Lethal Weapons,Weapons"};

            foreach (string line in all) {
                string[] parts = line.Split(',');
                Add(parts[0], parts[1]);
            }


        }

        public void Add(string cmmdty, string category) {
            Commodity random = Commodity.CommodityFactory.Create(cmmdty, category);
            try {
                _repository.Add(random);
            } catch (StorageException exc) {
                Console.WriteLine("{0}: {1}", cmmdty, exc);
            }
        }

        [Test]
        public void GetSilverShouldReturn() {
            Commodity silver = _repository.Get("silver");

            Assert.IsNotNull(silver);

        }

        [Test]
        public void QueryShouldRetrieveAllEntities()
        {
            IEnumerable<Commodity> all = _repository.Query();

            Assert.AreNotEqual(0, all.Count());
        }
    }
}
