namespace Sharpsolutions.Edt.Domain.Trade
{
    public abstract class StarportBuilderBase : IStarportBuilder
    {
        public virtual Starport Build(string name, string system) {
            SolarSystem solarSystemy = new SolarSystem(system);

            Starport starport = Starport.Create(name, solarSystemy, Economy.Industrial);

            AddGoods(starport);

            return starport;
        }

        protected abstract void AddGoods(Starport starport);
    }
}