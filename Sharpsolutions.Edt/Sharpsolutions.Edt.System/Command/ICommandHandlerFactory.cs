using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Command {

    public interface ICommandHandlerFactory {
        ICommandHandler<TCommand> Create<TCommand>();
        void Release(ICommandHandler handler);
    }
}
