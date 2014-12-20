using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Sharpsolutions.Edt.System.Domain;

namespace Sharpsolutions.Edt.Domain.Trade
{
    public class Starport : IEntity
    {
        public virtual string Name { get; protected set; }
        public virtual SolarSystem System { get; protected set; }

        public virtual Economy Economy { get; protected set; }

        public virtual ICollection<StockItem> Goods { get; protected set; }
        public virtual Guid Id { get; protected set; }

        public bool Sells(Commodity commodity)
        {
            return Goods.Where(g => g.Commodity.Equals(commodity) && g.Buy.HasValue).Any();
        }

        public bool Buys(Commodity commodity)
        {
            return Goods.Where(g => g.Commodity.Equals(commodity) && g.Sell.HasValue).Any();
        }

        public static Starport Load(string name, string system, string economy)
        {
            Starport starport = new Starport
            {
                Economy = Economy.Parse(economy),
                Name = name,
                System = new SolarSystem(system),
                Goods = new List<StockItem>()
            };

            return starport;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.Name, this.System.Name);
        }

        public static bool operator ==(Starport left, Starport right) {
            if (object.ReferenceEquals(left, null)) {
                return ReferenceEquals(right, null);
            }

            return left.Equals(right);
        }

        public static bool operator !=(Starport left, Starport right) {
            return !(left == right);
        }


        public override int GetHashCode() {
            return Name.GetHashCode() ^ System.Name.GetHashCode();
        }

        public override bool Equals(object obj) {
            Starport other = obj as Starport;
            if (other == null) {
                return false;
            }
            bool nameSame = string.Equals(this.Name, other.Name, StringComparison.InvariantCultureIgnoreCase);
            bool economySame = Economy == other.Economy;
            bool systemSame = System == other.System;
            
            return nameSame && economySame && systemSame;
        }

        public static Starport Create(string name, SolarSystem solarSystemy, Trade.Economy economy)
        {
            Starport starport = new Starport
            {
                Economy = economy,
                Name = name,
                System = solarSystemy,
                Goods = new List<StockItem>()
            };

            return starport;
        }

        public void Add(Commodity commodity)
        {
            this.Goods.Add(StockItem.New(commodity));
        }

        public void Update(Commodity commodity, int? sell, int? buy)
        {
            StockItem item = Goods.Single(g => g.Commodity == commodity);

            item.Update(sell, buy);
        }

        public IEnumerable<TradeCommodity> Exports()
        {
            return Goods.Where(g => g.Buy.HasValue)
                .Select(g => new TradeCommodity()
                {
                    Commodity = g.Commodity,
                    Price = g.Buy.Value
                });
        }

        public IEnumerable<TradeCommodity> Imports()
        {
            return Goods.Where(g => g.Sell.HasValue)
                .Select(g => new TradeCommodity() {
                    Commodity = g.Commodity,
                    Price = g.Sell.Value
                });
        }
    }
}
