using System;
using System.Data.Entity;
using System.Linq;
using Castle.Core.Logging;
using Sharpsolutions.Edt.Domain.Trade;
using Sharpsolutions.Edt.System.Data;

namespace Sharpsolutions.Edt.Data.Sql {
    public class StarportRepository: RepositoryBase<Starport>
    {
        public StarportRepository(DbContext dbContext, ILoggerFactory loggerFactory) : base(dbContext, loggerFactory)
        {
        }

        public StarportRepository(ILoggerFactory loggerFactory)
            : base(loggerFactory) {
        }

        public override void Add(Starport entity)
        {
            
           DbContext.Set<Starport>().Add(entity);
            
        }




        public override Starport Get(Guid id)
        {
            return DbContext.Set<Starport>().Find(id);
        }

        public override IQueryable<Starport> Query()
        {
            return DbContext.Set<Starport>().AsQueryable();
        }

        
    }
}
