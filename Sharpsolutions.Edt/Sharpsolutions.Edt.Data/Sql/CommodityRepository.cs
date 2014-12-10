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
    public class CommodityRepository: IRepository<Commodity>, IDisposable
    {
        private readonly ILogger _Logger;
        private readonly TradeDbContext _Context;
        private readonly bool _DisposeContext = false;

        public CommodityRepository(TradeDbContext context, ILoggerFactory loggerFactory) {
            _Context = context;
            _Logger = loggerFactory.Create(Loggers.System.Sql);

            _Context.Database.Log = (s) => _Logger.DebugFormat("{0}", s.Replace(Environment.NewLine, string.Empty));
        }

        public CommodityRepository(ILoggerFactory loggerFactory): this(new TradeDbContext(), loggerFactory)
        {
            _DisposeContext = true;
        }
       

        public void Add(Commodity entity)
        {
            _Context.Set<Commodity>().Add(entity);
        }

        public Commodity Get(string id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Commodity> Query()
        {
            return _Context.Set<Commodity>();
        }

        public void Dispose()
        {
            if (_DisposeContext)
            {
                _Context.Dispose();
            }
        }


        public void Commit()
        {
            _Context.SaveChanges();
        }
    }
}
