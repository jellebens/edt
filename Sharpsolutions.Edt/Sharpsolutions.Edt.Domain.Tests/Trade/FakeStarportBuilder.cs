using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Domain.Tests.Trade {
    public class FakeStarportBuilder {

        public static Starport Kaku()
        {
            StarportBuilder builder = new StarportBuilder("Kaku Orbital", "Chemaku", Economy.Industrial, new FakeCommodities().AllCommodities());

            Starport kaku = builder.Build();

            return kaku;
        }

        public static Starport AzebanCity()
        {
            StarportBuilder builder = new StarportBuilder("Azeban City", "Eranin", Economy.Agriculture, new FakeCommodities().AllCommodities());

            Starport azebanStarport = builder.Build();

            return azebanStarport;
        }
    }
}
