using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.System.Domain;

namespace Sharpsolutions.Edt.Domain.Trade {
    public class Starport: IEntity
    {
        public virtual string Name { get; protected set; }
        public virtual SolarSystem System { get; protected set; }

        public virtual Economy Economy { get; protected set; }

        public StockItems Goods { get; protected set; }

        public bool Sells(Commodity commodity)
        {
            return Goods.Where(g => g.Commodity.Equals(commodity) && g.Exports).Any();
        }

        public bool Buys(Commodity commodity) {
            return Goods.Where(g => g.Commodity.Equals(commodity) && g.Imports).Any();
        }

        public static Starport Load(string name, string system, string economy) {
            Starport starport = new Starport {
                Economy = Economy.Parse(economy),
                Name = name,
                System = new SolarSystem(system),
                Goods = new StockItems()
            };

            return starport;
        }

        public static Starport Create(string name, SolarSystem solarSystemy, Trade.Economy economy) {
            Starport starport = new Starport
            {
                Economy = economy,
                Name = name,
                System = solarSystemy,
                Goods = new StockItems()
            };

            return starport;
        }

        public void Add(string commodity, string category, bool exports, bool imports)
        {
            Commodity c = Commodity.CommodityFactory.Create(commodity, category);
            this.Goods.Add(StockItem.New(c, exports, imports));
        }

        
    }
}
