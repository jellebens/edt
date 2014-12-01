using Sharpsolutions.Edt.Contracts.Command.Account;
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
    public class RegisterUserHandler: ICommandHandler<RegisterUser>
    {
        private readonly IRepository<User, string> _Repository;
        public RegisterUserHandler(IRepository<User, string> repository) {
            _Repository = repository;    
        }

        public void Execute(RegisterUser command) {
            User user = User.Create(command.Username, command.Password);

            _Repository.Add(user);
        }
    }
}
