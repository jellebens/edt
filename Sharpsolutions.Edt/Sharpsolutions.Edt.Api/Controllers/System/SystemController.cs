using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Web.Http;
using System.Linq;

namespace Sharpsolutions.Edt.Api.Controllers.System
{
    [RoutePrefix("system")]
    public class SystemController : ApiController
    {
        private readonly DbContext _dbContext;

        public SystemController(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("")]
        [HttpGet]
        public IHttpActionResult Up()
        {
            int x = _dbContext.Database.SqlQuery<int>("SELECT COUNT(1) FROM [dbo].[__MigrationHistory]").Single();


            var status = new
            {
                Version = x
            };

            return Ok(status);
        }

        protected override void Dispose(bool disposing)
        {
            if (!disposing)
            {
                _dbContext.Dispose();
            }

            base.Dispose(disposing);

        }
    }
}
