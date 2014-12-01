using Sharpsolutions.Edt.System.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Contracts.Command.Account {
    [DataContract]
    public class RegisterUser : CommandBase {
        public static RegisterUser New(string username, string password) {
            RegisterUser cmd = new RegisterUser();
            cmd.Id = Guid.NewGuid();
            cmd.Username = username;
            cmd.Password = password;

            return cmd;
        }

        [DataMember]
        public string Username { get; protected set; }
        [DataMember]
        public string Password { get; protected set; }
    }
}
