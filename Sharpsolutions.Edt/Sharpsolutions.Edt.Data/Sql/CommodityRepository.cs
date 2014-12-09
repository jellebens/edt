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

        public CommodityRepository(TradeDbContext context, ILoggerFactory loggerFactory) {
            _Context = context;
            _Logger = loggerFactory.Create(Loggers.System.Sql);

            _Context.Database.Log = (s) => _Logger.DebugFormat("{0}", s.Replace(Environment.NewLine, string.Empty));
        }
       

        public void Add(Commodity entity)
        {
            throw new NotImplementedException();
        }

        public Commodity Get(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Commodity> Query()
        {
            throw new NotImplementedException();
        }

        public void Dispose() {
            throw new NotImplementedException();
        }
    }
}
