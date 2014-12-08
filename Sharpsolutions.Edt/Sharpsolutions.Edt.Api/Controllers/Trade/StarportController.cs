using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.WindowsAzure.Storage.Table;
using Sharpsolutions.Edt.Api.Models.Trade;
using Sharpsolutions.Edt.Contracts.Command.Universe;
using Sharpsolutions.Edt.System.Command;
using Sharpsolutions.Edt.System.Data;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Api.Controllers.Trade {
    [RoutePrefix("starport")]
    public class StarportController : ApiController {
        private readonly IBus _Bus;
        private IRepository<Starport> _repository;
        public StarportController(IBus bus, IRepository<Starport> repository) {
            _Bus = bus;
            _repository = repository;
        }

        [Route("")]
        [Authorize]
        [HttpGet]
        public StarportListModel[] List() {
            IEnumerable<Starport> starports = _repository.Query();

            StarportListModel[] result = starports.OrderBy(s => s.Name).Select(s => new StarportListModel() {
                Economy = s.Economy.DisplayName,
                Name = s.Name,
                System = s.System.Name
            }).ToArray();

            return result;
        }

        [Route("detail")]
        [Authorize]
        [HttpGet]
        public StarportUpdateModel Detail(string name)
        {
            Starport starport = _repository.Get(name);

            StarportUpdateModel result = new StarportUpdateModel();
            result.Economy = starport.Economy.DisplayName;
            result.Name = starport.Name;
            result.System = starport.System.Name;

            result.Goods = starport.Goods.Select(g => new StockItemModel()
            {
                Name = g.Commodity.Name,
                Category = g.Commodity.Category.Name,
                Import = g.Imports,
                Export = g.Exports

            }).ToArray();
            
            return result;
        }

        [Route("create")]
        [Authorize]
        [HttpPost]
        public IHttpActionResult Create(StartportCreateModel createModel) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            CreateStarport cmd = CreateStarport.New(createModel.Name, createModel.System, createModel.Economy);

            _Bus.Publish(cmd);

            return Ok();
        }
    }
}
