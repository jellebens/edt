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

        public CreateStarportHandler(IRepository<Starport> starportRepository)
        {
            _starportRepository = starportRepository;
        }

        public override void Execute(CreateStarport command)
        {
            StarportBuilder builder = new StarportBuilder(command.Name, command.System, Economy.Parse(command.Economy));

            Starport starport = builder.Build();

            _starportRepository.Add(starport);
        }
    }
}
