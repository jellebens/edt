using Microsoft.AspNet.Identity;
using Sharpsolutions.Edt.Api.Models.Account;
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
        [AllowAnonymous]
        [Route("register")]

        public IHttpActionResult Register(CreateModel model) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            ///TODO register the user :p
            ///

            return Ok();
        }
    }
}
