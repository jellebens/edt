using Microsoft.AspNet.Identity;
using Sharpsolutions.Edt.Api.Models.Account;
using Sharpsolutions.Edt.Contracts.Command.Account;
using Sharpsolutions.Edt.System.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sharpsolutions.Edt.Api.Controllers
{
    [RoutePrefix("account")]
    public class AccountController : ApiController
    {
        private readonly IBus _Bus;
        public AccountController(IBus bus) {
            _Bus = bus;
        }

        [AllowAnonymous]
        [Route("register")]

        public IHttpActionResult Register(CreateModel model) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            RegisterUserCommand cmd = RegisterUserCommand.New(model.UserName, model.Password);
            
            _Bus.Publish(cmd);

            return Ok();
        }
    }
}
