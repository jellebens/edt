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
            kaku.Update(FakeCommodities.Gallium, null, 5818);
            return kaku;
        }

        public static Starport HuiMines()
        {
            StarportBuilder builder = new StarportBuilder("Hui Mines", "Ciguru", Economy.Refinery, new FakeCommodities().AllCommodities());

            Starport huiMines = builder.Build();
            huiMines.Update(FakeCommodities.Gallium, 5133, 5191);


            return huiMines;
        }
    }
}
