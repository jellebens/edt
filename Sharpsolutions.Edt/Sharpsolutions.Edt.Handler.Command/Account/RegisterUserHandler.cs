using Sharpsolutions.Edt.Contracts.Command.Account;
using Sharpsolutions.Edt.System.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Handler.Command.Account
{
    public class RegisterUserHandler: ICommandHandler<RegisterUser>
    {
        public void Execute(RegisterUser command) {
            throw new NotImplementedException();
        }
    }
}
