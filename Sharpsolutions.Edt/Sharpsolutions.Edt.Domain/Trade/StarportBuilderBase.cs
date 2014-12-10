using System.Linq;

namespace Sharpsolutions.Edt.Domain.Trade
{
    public abstract class StarportBuilderBase : IStarportBuilder
    {
        protected IQueryable<Category> _Categories;
        public virtual Starport Build(string name, string system) {
            SolarSystem solarSystemy = new SolarSystem(system);

            Starport starport = Starport.Create(name, solarSystemy, Economy.Industrial);

            AddGoods(starport);

            return starport;
        }

        public void AddCategories(IQueryable<Category> categories)
        {
            _Categories = categories;
        }

        protected abstract void AddGoods(Starport starport);
    }
}