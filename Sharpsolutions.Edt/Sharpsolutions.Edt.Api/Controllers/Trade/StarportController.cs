using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using Sharpsolutions.Edt.Api.Models.Trade;
using Sharpsolutions.Edt.Contracts.Command.Trade;
using Sharpsolutions.Edt.Data.Azure;
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
        public IHttpActionResult List() {
            return BadRequest("Not implemented yet");
        }

        [Route("detail")]
        [Authorize]
        [HttpGet]
        public IHttpActionResult Detail(string name)
        {
            return BadRequest("Not implemented yet");
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

            return Ok(cmd.Id);
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

            return Ok(command.Id);
        }
    }
}
