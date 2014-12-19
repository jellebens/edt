using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using Sharpsolutions.Edt.Api.Models.Trade;
using Sharpsolutions.Edt.Contracts.Command.Trade;
using Sharpsolutions.Edt.System.Command;
using Sharpsolutions.Edt.System.Data;
using Sharpsolutions.Edt.Domain.Trade;
using Dto = Sharpsolutions.Edt.Contracts.Data;

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
        public StarportDetailModel Detail(string name) {
            Starport starport = _repository.Query()
                .Include(x => x.Goods.Select(g => g.Commodity.Category))
                .Single(x => x.Name == name);

            StarportDetailModel result = new StarportDetailModel();
            result.Economy = starport.Economy.DisplayName;
            result.Name = starport.Name;
            result.System = starport.System.Name;

            result.Goods = starport.Goods.Select(g => new StockItemModel() {
                Name = g.Commodity.Name,
                Category = g.Commodity.Category.Name,
                Sell = g.Sell,
                Buy =  g.Buy


            }).OrderBy(x => x.Category).ToArray();

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

        [Route("stock/update")]
        [Authorize]
        [HttpPost]
        public IHttpActionResult Update(StockUpdateViewModel updateModel) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }


            UpdateInventoryCommand command = UpdateInventoryCommand.Create(updateModel.Name, updateModel.System ,updateModel.Goods.Select(g => new Dto.InventoryItem() {
                Buy = g.Buy,
                Category = g.Category,
                Sell = g.Sell,
                Commodity = g.Name
            }).ToArray());

            _Bus.Publish(command);

            return Ok();
        }
    }
}
