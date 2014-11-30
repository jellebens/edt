using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sharpsolutions.Edt.Api.Controllers {
    [RoutePrefix("commodities")]
    [Authorize]
    public class CommoditiesController : ApiController {
        [Route("")]
        public IHttpActionResult Commodities() {
            
            var x = new[] {
                        new { Category= "Machinery", Name= "Mineral Extractors" },
                        new { Category= "Metals", Name= "Gallium" }
                   };
        

            return Ok(x);
        }

    }
}
