using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sharpsolutions.Edt.Domain.Trade {
    public class TradeRouteFinder {
        private readonly IEnumerable<Starport> _starports;

        public TradeRouteFinder(IEnumerable<Starport> starports) {
            _starports = starports;
        }

        public TradeRoute Find(Starport origin) {
            var tradeRoutes = FindAll(origin);
            return tradeRoutes.Where(t => t.Profit == tradeRoutes.Max(m => m.Profit)).First();
        }

        public IEnumerable<TradeRoute> FindAll(Starport origin) {
            IEnumerable<TradeCommodity> exports = origin.Exports().ToList();

            List<TradeRoute> tradeRoutes = new List<TradeRoute>();

            foreach (Starport destination in _starports) {
                IEnumerable<TradeCommodity> imports = destination.Imports();

                foreach (TradeCommodity import in imports) {
                    TradeCommodity export = exports.SingleOrDefault(e => e.Commodity == import.Commodity);

                    if (export != null) {
                        TradeRoute route = TradeRoute.Create(origin, destination, export.Commodity, import.Price, export.Price);
                        tradeRoutes.Add(route);
                    }
                }
            }
            return tradeRoutes.Where(t => t.Profit > 0);
        }
    }
}
