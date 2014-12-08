using Sharpsolutions.Edt.System.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Worker.Command {
    public class CommandProcessor : ICommandProcessor {
        private readonly ICommandHandlerFactory _HandlerFactory;

        public CommandProcessor(ICommandHandlerFactory factory) {
            _HandlerFactory = factory;
        }

        public void Execute<TCommand>(TCommand command) where TCommand : ICommand
        {
            ICommandHandler<TCommand> handler = _HandlerFactory.Create<TCommand>();
            try {
                handler.Execute(command);
            } finally {
                _HandlerFactory.Release(handler);
            }
        }
    }
}
