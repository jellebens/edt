using Sharpsolutions.Edt.Contracts.Command.Universe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Domain.Trade;
using Sharpsolutions.Edt.System.Data;

namespace Sharpsolutions.Edt.Handler.Command.Trade {
    public class CreateStarportHandler: CommandHandlerBase<CreateStarport>
    {
        private readonly IRepository<Starport> _starportRepository;
        private readonly IRepository<Commodity> _commoditiesRepository;

        public CreateStarportHandler(IRepository<Starport> starportRepository, IRepository<Commodity> commoditiesRepository)
        {
            _starportRepository = starportRepository;
            _commoditiesRepository = commoditiesRepository;
        }

        public override void Execute(CreateStarport command)
        {
            StarportBuilder builder = new StarportBuilder(command.Name, command.System, Economy.Parse(command.Economy), _commoditiesRepository.Query());

            Starport starport = builder.Build();

            _starportRepository.Add(starport);

            _starportRepository.Commit();
        }
    }
}
