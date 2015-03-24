using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Domain.Account.Events;
using Sharpsolutions.Edt.System.Domain;

namespace Sharpsolutions.Edt.Domain.Account {
    public class UUser : AgregateRootBase {

        private UUser()
        {
            
        }

        protected override void RegisterHandlers()
        {
            Register<UserCreated>(OnUserCreated);
            Register<InvalidPasswordSupplied>(OnInvalidPasswordSupplied);
        }


        public static UUser Create(string username, string password)
        {
            UUser user = new UUser();

            user.Apply((EventBase) new UserCreated(username, Password.New(password)));

            return user;
        }

        private void OnUserCreated(UserCreated userCreated)
        {
            Id = Guid.NewGuid();
            Username = userCreated.Username;
            Password = userCreated.Password;
            Version = 1;
        }

        private void OnInvalidPasswordSupplied(InvalidPasswordSupplied @event)
        {
            this.InvalidAttempts++;
        }

        public string Username { get; private set; }

        public Password Password { get; private set; }
        public int InvalidAttempts { get; private set; }

        public bool Verify(string password)
        {
            bool result = this.Password.Equals(password);

            if (!result)
            {
                base.Apply(new InvalidPasswordSupplied());
            }

            return result;
        }
    }
}
