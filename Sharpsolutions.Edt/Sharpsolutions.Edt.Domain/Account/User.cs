using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Domain.Account.Events;
using Sharpsolutions.Edt.System.Domain;

namespace Sharpsolutions.Edt.Domain.Account {
    public class User : AgregateRootBase {

        protected User()
        {
            
        }
        
        protected override void RegisterHandlers()
        {
            Register<UserCreated>(OnUserCreated);
            Register<InvalidPasswordSupplied>(OnInvalidPasswordSupplied);
            Register<UserLoggedIn>(OnUserLoggedIn);
        }


        public static User Create(string username, string password)
        {
            User user = new User();
            
            user.Apply(new UserCreated(username, Password.New(password).Hash));

            return user;
        }

        private void OnUserCreated(UserCreated userCreated)
        {
            Id = Guid.NewGuid();
            Username = userCreated.Username;
            Password = new Password(userCreated.PasswordHash);
        }

        private void OnInvalidPasswordSupplied(InvalidPasswordSupplied @event)
        {
            this.InvalidAttempts++;
        }

        private void OnUserLoggedIn(UserLoggedIn userLogged) {
            
        }

        public string Username { get; private set; }

        public Password Password { get; private set; }
        public int InvalidAttempts { get; private set; }
        
        public bool TryLogin(string password) {
            bool result = this.Password.Equals(password);

            if (!result) {
                base.Apply(new InvalidPasswordSupplied());
            }
            else
            {
                Apply(new UserLoggedIn());
            }

            return result;
        }
    }
}
