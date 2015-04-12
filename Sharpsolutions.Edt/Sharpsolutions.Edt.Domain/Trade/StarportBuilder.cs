using Sharpsolutions.Edt.Domain.Core;
using Sharpsolutions.Edt.Domain.Trade.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Domain.Trade {
    public class StarportBuilder
    {
        private SolarSystem _solarSystem;
        private string _name;

        public StarportBuilder(string name, SolarSystem system) {
            if (string.IsNullOrWhiteSpace(name)) {
                throw new ArgumentException("name");
            }

            if (system == null) {
                throw new ArgumentException("system");
            }

            _name = name;
            _solarSystem = system;
        }

        public Starport Build()
        {
            Starport starport = Starport.Create(_name, _solarSystem);
            
            return starport;
        }
    }
}
