using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sharpsolutions.Edt.Domain.Trade;
using Sharpsolutions.Edt.Domain.Tests.Trade.Fakes;

namespace Sharpsolutions.Edt.Domain.Tests.Trade {
    [TestFixture]
    public class TradeRouteFinderTests {
        

        [Test]
        public void FindHAvingOnlyOneOtherStarportShouldCalculateProfit()
        {
            Starport origin = Starports.HuiMines();
            Starport[] destinations = new[]
            {
                Starports.Kaku(),
                Starports.HuiMines()
            };

            TradeRouteCalculator finder = new TradeRouteCalculator(destinations);

            TradeRoute route = finder.Find(origin);

            Assert.AreEqual(5133, route.Buy);
            Assert.AreEqual(5818, route.Sell);
            Assert.AreEqual(685, route.Profit);
            Assert.AreNotEqual(Starports.HuiMines(), route.Destination);
            
        }
    }
}
