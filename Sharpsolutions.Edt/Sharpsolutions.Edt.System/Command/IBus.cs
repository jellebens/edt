using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Command {
    public interface IBus {
        void Publish<TCommand>(TCommand command) where TCommand: ICommand;
    }
}