using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Domain.Account.Events;
using Sharpsolutions.Edt.System.Domain;

namespace Sharpsolutions.Edt.Domain.Account {
    public class User : AgregateRootBase, IEventSourced {

        protected User()
        {
            
        }
        
        protected override void RegisterHandlers()
        {
            Register<UserCreated>(OnUserCreated);
            Register<InvalidPasswordSupplied>(OnInvalidPasswordSupplied);
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
        

        void IEventSourced.ClearPendingChanges() {
            throw new NotImplementedException();
        }

        void IEventSourced.Load<TEvent>(IEnumerable<TEvent> events) {
            this.ApplyHistory(events.ToArray());
        }
    }
}
