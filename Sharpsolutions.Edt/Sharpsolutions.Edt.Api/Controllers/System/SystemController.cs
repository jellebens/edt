using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Web.Http;
using System.Linq;
using Microsoft.Azure;

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
            try
            {
                string s = CloudConfigurationManager.GetSetting("default");
                Trace.Write(s);
                int x = _dbContext.Database.SqlQuery<int>("SELECT COUNT(1) FROM [dbo].[__MigrationHistory]").Single();


                var status = new {
                    Version = x
                };

                return Ok(status);
            }
            catch (Exception exc)
            {
                return BadRequest(exc.Message);
            }
            
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
