using Castle.Core.Logging;
using Sharpsolutions.Edt.Api.Models.Core;
using Sharpsolutions.Edt.Data.Azure;
using Sharpsolutions.Edt.System.Command;
using Sharpsolutions.Edt.System.Data;
using Sharpsolutions.Edt.System.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Sharpsolutions.Edt.Api.Controllers.System {
	[RoutePrefix("command")]
	public class CommandController : ApiController {
		private readonly ILogger _logger;
		private readonly IJobRepository _JobRepository;

		public CommandController(IJobRepository jobRepository, ILoggerFactory loggerFactory) {
			_JobRepository = jobRepository;
			_logger = loggerFactory.Create(Loggers.Commanding.Worker);

		}
		[HttpGet]
		[Authorize]
		[Route("checkresult")]
		public IHttpActionResult Query(Guid commandId) {
			Job job = _JobRepository.Get(commandId);

			JobResult result = new JobResult()
			{
				HasError = job.Status == JobStatus.Error,
				InProgress = job.Status == JobStatus.InProgress,
				IsComplete = job.Status == JobStatus.Done || job.Status == JobStatus.Error
			};

			return Ok(result);
		}
	}
}
