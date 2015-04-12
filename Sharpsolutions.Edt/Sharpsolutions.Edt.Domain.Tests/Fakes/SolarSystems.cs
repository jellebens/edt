using Sharpsolutions.Edt.Domain.Core;
using Sharpsolutions.Edt.Domain.Trade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Domain.Tests.Fakes {
    public class SolarSystems {

        public static SolarSystem Daibara => new SolarSystem("Daibara", new Coordinate(-102.5625, 76.46875, -41.375));

        public static SolarSystem Kocab => new SolarSystem("Kocab", new Coordinate(-91.78125,85.3125, -38));
    }
}
