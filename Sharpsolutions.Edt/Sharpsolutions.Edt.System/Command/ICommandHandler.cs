using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sharpsolutions.Edt.System.Command {
    public interface ICommandHandler {

    }

    public interface ICommandHandler<in TCommand>: ICommandHandler
    where TCommand : ICommand
    {
        void Execute(TCommand command);
    }
}
