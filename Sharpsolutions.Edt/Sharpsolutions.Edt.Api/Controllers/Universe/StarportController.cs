using Sharpsolutions.Edt.System.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sharpsolutions.Edt.Api.Models.Universe;
using Sharpsolutions.Edt.Contracts.Command.Account;
using Sharpsolutions.Edt.Contracts.Command.Universe;

namespace Sharpsolutions.Edt.Api.Controllers.Universe {
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
