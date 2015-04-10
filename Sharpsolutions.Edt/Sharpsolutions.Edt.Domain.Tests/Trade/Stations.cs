using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Domain.Core;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Domain.Tests.Trade
{
    public class Stations
    {
        public static Station McKayPort()
        {
            StationBuilder builder = new StationBuilder();
            builder.Distance(493, Length.Ls);
            builder.LandingPad(Size.L);
            builder.Facilities(Facility.Commodities, Facility.Outfitting, Facility.Rearm, Facility.Refuel,
                Facility.Shipyard, Facility.Repair);


            return builder.Build();
        }
    }
}