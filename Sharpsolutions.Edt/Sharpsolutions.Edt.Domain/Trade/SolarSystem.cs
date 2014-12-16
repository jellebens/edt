using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;

namespace Sharpsolutions.Edt.Domain.Trade {
    public class SolarSystem
    {
        protected SolarSystem()
        {

        }

        public SolarSystem(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
        public Guid Id { get; set; }
    }
}
