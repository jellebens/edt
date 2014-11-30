using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Command {
    public abstract class CommandBase: ICommand  {
        public Guid Id { get; protected set; }

    }
}
