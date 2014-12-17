using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter.Xml;
using Castle.Core.Logging;
using Sharpsolutions.Edt.Contracts.Command.Trade;
using Sharpsolutions.Edt.Data.Sql;
using Sharpsolutions.Edt.Domain.Trade;
using Sharpsolutions.Edt.System.Data;

namespace Sharpsolutions.Edt.Handler.Command.Trade {
    public class CreateStarportHandler: CommandHandlerBase<CreateStarport>, IDisposable
    {
        private readonly DbContext _dbContext;
        private readonly RepositoryBase<Starport> _starportRepository;
        

        public CreateStarportHandler(DbContext dbContext, ILoggerFactory loggerFactory)
        {
            _dbContext = dbContext;
            _starportRepository = new StarportRepository(_dbContext, loggerFactory);
        }

        public override void Execute(CreateStarport command)
        {
            IQueryable<Commodity> commodities = _dbContext.Set<Commodity>()
                                                            .Include(c => c.Category)
                                                            .ToList()
                                                            .AsQueryable();


            Economy economy = _dbContext.Set<Economy>().Single(e => e.DisplayName == command.Economy);

            StarportBuilder builder = new StarportBuilder(command.Name, command.System, economy, commodities);

            Starport starport = builder.Build();

            _starportRepository.Add(starport);

            _starportRepository.Commit();
        }

        public void Dispose() {
            _starportRepository.Dispose();
            _dbContext.Dispose();
        }
    }
}
