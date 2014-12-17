using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using Sharpsolutions.Edt.Contracts.Command.Trade;
using Sharpsolutions.Edt.Contracts.Data;
using Sharpsolutions.Edt.Data.Sql;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Handler.Command.Trade {
    public class UpdateInventoryCommandHandler : CommandHandlerBase<UpdateInventoryCommand>
    {
        private readonly DbContext _dbContext;
        private readonly RepositoryBase<Starport> _starportRepository;


        public UpdateInventoryCommandHandler(DbContext dbContext, ILoggerFactory loggerFactory)
        {
            _dbContext = dbContext;
            _starportRepository = new StarportRepository(dbContext, loggerFactory);
        }

        public override void Execute(UpdateInventoryCommand command)
        {
            IQueryable<Commodity> commodities =  _dbContext.Set<Commodity>().AsQueryable();
            
            Starport starport = _starportRepository.Query().Single(s => s.Name == command.Starport && s.System.Name == command.System);

            foreach (InventoryItem item in command.Goods.Where(g => g.Buy.HasValue))
            {
                Commodity commodity =
                    commodities.Single(c => c.Name == item.Commodity && c.Category.Name == item.Category);

                starport.Update(commodity, item.Sell, item.Buy);
            }

            _starportRepository.Commit();
        }
    }
}
