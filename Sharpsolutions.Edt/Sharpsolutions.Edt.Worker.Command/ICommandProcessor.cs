using Sharpsolutions.Edt.System.Command;
using System;
namespace Sharpsolutions.Edt.Worker.Command {
    interface ICommandProcessor
    {
        void Execute<TCommand>(TCommand command) 
            where TCommand : ICommand;
    }
}
