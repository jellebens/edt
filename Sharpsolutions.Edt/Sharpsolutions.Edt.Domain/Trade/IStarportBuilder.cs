using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Sharpsolutions.Edt.Domain.Trade
{
    public interface IStarportBuilder
    {
        Starport Build(string name, string solarSystem, IQueryable<Commodity> commodities);

    }
}