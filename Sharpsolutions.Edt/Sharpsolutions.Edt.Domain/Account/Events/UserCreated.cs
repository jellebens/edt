using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.System.Domain;

namespace Sharpsolutions.Edt.Domain.Account.Events {
    public class UserCreated : EventBase {
        public string Username { get; private set; }
        public string PasswordHash { get; private set; }
        public DateTime Timestamp { get; set; }

        public UserCreated(string username, string passwordHash) {
            Username = username;
            PasswordHash = passwordHash;
            Timestamp = DateTime.UtcNow;
        }
    }
}
