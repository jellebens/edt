using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public virtual ICollection<StockItem> Goods { get; protected set; }
        public virtual Guid Id { get; protected set; }

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
                Goods = new List<StockItem>()
            };

            return starport;
        }

        public static Starport Create(string name, SolarSystem solarSystemy, Trade.Economy economy) {
            Starport starport = new Starport
            {
                Economy = economy,
                Name = name,
                System = solarSystemy,
                Goods = new List<StockItem>()
            };

            return starport;
        }

        public void Add(Commodity commodity, bool exports, bool imports)
        {
            this.Goods.Add(StockItem.New(commodity, exports, imports));
        }

        public void Update(Commodity commodity, int? sell, int? buy)
        {
            StockItem item = Goods.Single(g => g.Commodity == commodity);

            item.Update(sell, buy);
        }
    }
}
