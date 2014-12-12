using System.Collections.Generic;
using System.Linq;

namespace Sharpsolutions.Edt.Domain.Trade
{
    public abstract class StarportBuilderBase : IStarportBuilder
    {
        protected IQueryable<Commodity> _Commodities;

        public virtual Starport Build(string name, string system, IQueryable<Commodity> commodities)
        {
            _Commodities = commodities;

            SolarSystem solarSystemy = new SolarSystem(system);

            Starport starport = Starport.Create(name, solarSystemy, Economy.Industrial);

            AddGoods(starport);

            return starport;
        }


        public virtual Commodity GetCommodity(string name)
        {
            return _Commodities.Single(x => x.Name == name);
        }


        protected abstract void AddGoods(Starport starport);
    }
}