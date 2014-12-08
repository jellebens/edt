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


        public StarportBuilder(string name, string system, Economy economy)
        {
            _SolarSystemName = system;
            _Name = name;
            _Economy = economy;
        
            _builders.Add(Economy.Extraction, new ExtractionBuilder());
            _builders.Add(Economy.Refinery, new RefineryBuilder());
            _builders.Add(Economy.Agriculture, new AgricultureBuilder());
            _builders.Add(Economy.Industrial, new IndustrialBuilder());
            _builders.Add(Economy.HighTech, new HighTechBuilder());

        }



        public Starport Build()
        {
            IStarportBuilder builder = _builders[_Economy];

            return builder.Build(_Name, _SolarSystemName);
        }
    }
}
