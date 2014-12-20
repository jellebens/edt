namespace Sharpsolutions.Edt.Domain.Trade
{
    public class TradeRoute
    {
        public virtual int Profit
        {
            get { return Buy - Sell; }
        }

        public virtual Commodity Commodity { get; protected set; }

        public virtual int Buy { get; protected set; }

        public virtual int Sell { get; protected set; }

        public virtual Starport Origin { get; protected set; }

        public virtual Starport Destination { get; protected set; }

        public static TradeRoute Create(Starport origin, Starport destination, Commodity commodity, int buy, int sell)
        {
            TradeRoute route = new TradeRoute();
            route.Commodity = commodity;
            route.Origin = origin;
            route.Destination = destination;
            route.Buy = buy;
            route.Sell = sell;
            
            return route;
        }
    }
}