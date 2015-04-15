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
        [Ignore("Ignored due to refactoring in progress")]
        public void FindHAvingOnlyOneOtherStarportShouldCalculateProfit()
        {
            Starport origin = Starports.DrzewieckiGateway;
            Starport[] destinations = new[]
            {
                Starports.McKayPort,
                Starports.DrzewieckiGateway
            };

            TradeRouteCalculator finder = new TradeRouteCalculator(destinations);

            TradeRoute route = finder.Find(origin);

            Assert.AreEqual(5133, route.Buy);
            Assert.AreEqual(5818, route.Sell);
            Assert.AreEqual(685, route.Profit);
            Assert.AreNotEqual(Starports.DrzewieckiGateway, route.Destination);
            
        }
    }
}
