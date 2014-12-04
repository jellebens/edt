using System;
namespace Sharpsolutions.Edt.Worker.Command {
    interface ICommandProcessor {
        void Execute<TCommand>(TCommand command);
    }
}
