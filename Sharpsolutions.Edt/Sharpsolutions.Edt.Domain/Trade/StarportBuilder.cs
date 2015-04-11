using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Domain.Trade {
    public class StarportBuilder
    {
        
        private readonly string _SolarSystemName;
        private readonly string _Name;
        private readonly Economy _Economy;
        private readonly Dictionary<Economy, IStarportBuilder> _builders = new Dictionary<Economy, IStarportBuilder>();
        private readonly IQueryable<Commodity> _Commodities;

        public StarportBuilder(string name, string system, Economy economy, IQueryable<Commodity> commodities)
        {
            _SolarSystemName = system;
            _Name = name;
            _Economy = economy;
            _Commodities = commodities;

            

        }

        public Starport Build()
        {
            throw new NotImplementedException();
        }
    }
}
