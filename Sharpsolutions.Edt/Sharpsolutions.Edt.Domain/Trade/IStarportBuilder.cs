namespace Sharpsolutions.Edt.Domain.Trade
{
    public interface IStarportBuilder
    {
        Starport Build(string name, string solarSystem);

    }
}