using Sharpsolutions.Edt.Contracts.Command.Account;
using Sharpsolutions.Edt.Data.Azure;
using Sharpsolutions.Edt.Domain.Account;
using Sharpsolutions.Edt.System.Command;
using Sharpsolutions.Edt.System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Handler.Command.Account
{
    public class RegisterUserHandler: CommandHandlerBase<RegisterUser>
    {
        private readonly IUserRepository _Repository;
        public RegisterUserHandler(IUserRepository repository) {
            _Repository = repository;    
        }

        public override void Execute(RegisterUser command) {
            User user = User.Create(command.Username, command.Password);

            _Repository.Add(user);
        }
    }
}
