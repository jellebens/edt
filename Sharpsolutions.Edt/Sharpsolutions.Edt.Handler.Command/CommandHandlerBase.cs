using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.System.Command;

namespace Sharpsolutions.Edt.Handler.Command
{
    public abstract class CommandHandlerBase<TCommand> : ICommandHandler<TCommand>
        where TCommand : CommandBase
    {
        public abstract void Execute(TCommand command);
    }
}
