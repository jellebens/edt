using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.System;

namespace Sharpsolutions.Edt.Domain.Core {
    public class Facility : Enumeration {
        public static Facility Commodities = new Facility(1, "Commodities");
        public static Facility Outfitting = new Facility(2, "Outfitting");
        public static Facility Rearm = new Facility(4, "Rearm");
        public static Facility Refuel = new Facility(8, "Refuel");
        public static Facility Shipyard = new Facility(16, "Shipyard");
        public static Facility Repair = new Facility(32, "Repair");
        public static Facility Blackmarket = new Facility(64, "Blackmarket");

        public Facility(int value, string displayName) : base(value, displayName)
        {
        }
    }
}
