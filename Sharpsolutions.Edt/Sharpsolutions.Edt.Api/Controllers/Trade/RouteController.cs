using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using Sharpsolutions.Edt.Api.Models.Trade;
using Sharpsolutions.Edt.Data.Sql;
using Sharpsolutions.Edt.Domain.Trade;
using Sharpsolutions.Edt.System.Data;

namespace Sharpsolutions.Edt.Api.Controllers.Trade {
    
    [RoutePrefix("trade")]
    public class RouteController: ApiController {
        private DbContext _Context;


        public RouteController(DbContext context)
        {
            _Context = context;
        }



        [Route("destinations")]
        [HttpGet]
        public TradeRouteModel[] Destinations(string name)
        {
            List<TradeRouteModel> result = new List<TradeRouteModel>();
            
            IQueryable<Starport> starports = _Context.Set<Starport>()
                .Include(x => x.Goods)
                .Include(x => x.System)
                .Include(x => x.Goods.Select(c => c.Commodity))
                .Include(x => x.Goods.Select(c => c.Commodity.Category));

            TradeRouteFinder calculator = new TradeRouteFinder(starports.ToList());

            foreach (Starport origin in starports.Where(x => x.Name == name))
            {
                IEnumerable<TradeRoute> routes = calculator.FindAll(origin);

                foreach (TradeRoute route in routes)
                {
                    TradeRouteModel model = new TradeRouteModel();
                    model.Category = route.Commodity.Category.Name;
                    model.Commodtiy = route.Commodity.Name;
                    model.Destination = new StarportModel()
                    {
                        Name = route.Destination.Name,
                        System = route.Destination.System.Name
                    };
                    model.Origin = new StarportModel()
                    {
                        Name = origin.Name,
                        System = origin.System.Name
                    };
                    model.Profit = route.Profit;

                    result.Add(model);
                }


                
            }

            return result.ToArray();
        }
    }
}