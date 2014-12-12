using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.System.Data;
using Sharpsolutions.Edt.Domain.Trade;
using System.Reflection;
using Castle.Core.Logging;
using Sharpsolutions.Edt.Data.Sql.Mappings;
using Sharpsolutions.Edt.System.Logging;

namespace Sharpsolutions.Edt.Data.Sql {
    public class CommodityRepository : RepositoryBase<Commodity>
    {
        
        public CommodityRepository(EdtDbContext dbContext, ILoggerFactory loggerFactory) : base(dbContext, loggerFactory)
        {
            
        }

        public CommodityRepository(ILoggerFactory loggerFactory): base(loggerFactory)
        {
            
        }


        

        public override void Add(Commodity entity)
        {
            DbContext.Set<Commodity>().Add(entity);
        }

        public override Commodity Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public override IQueryable<Commodity> Query()
        {
            return DbContext.Set<Commodity>();
        }

    }
}
