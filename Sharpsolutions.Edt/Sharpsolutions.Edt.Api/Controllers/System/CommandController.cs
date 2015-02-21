using Sharpsolutions.Edt.Data.Azure;
using Sharpsolutions.Edt.System.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sharpsolutions.Edt.Api.Controllers.System
{
    [RoutePrefix("command")]
    public class CommandController : ApiController
    {
        private readonly IJobRepository _JobRepository;

        public CommandController(IJobRepository jobRepository) {
            _JobRepository = jobRepository;
        }
        [HttpGet]
        public Job Query(Guid commandId) {
             return _JobRepository.Get(commandId);
        }
    }
}
