using Sharpsolutions.Edt.System.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Contracts.Command.Account {
    public class RegisterUserCommand : CommandBase {
        public static RegisterUserCommand New(string username, string password) {
            RegisterUserCommand cmd = new RegisterUserCommand();
            cmd.Id = Guid.NewGuid();
            cmd.Username = username;
            cmd.Password = password;

            return cmd;
        }

        public string Username { get; protected set; }

        public string Password { get; protected set; }
    }
}
