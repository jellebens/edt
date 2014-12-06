using System.Web.Http;
using Sharpsolutions.Edt.Api.Models.Universe;
using Sharpsolutions.Edt.Contracts.Command.Universe;
using Sharpsolutions.Edt.System.Command;

namespace Sharpsolutions.Edt.Api.Controllers.Trade {
    [RoutePrefix("starport")]
    public class StarportController : ApiController {
        private readonly IBus _Bus;
        public StarportController(IBus bus) {
            _Bus = bus;
        }

        [Route("create")]
        [Authorize]
        [HttpPost]
        public IHttpActionResult Create(StartportCreateModel createModel)
        {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            CreateStarport cmd = CreateStarport.New(createModel.Name, createModel.System, createModel.Economy);

            _Bus.Publish(cmd);

            return Ok();
        }
    }
}
