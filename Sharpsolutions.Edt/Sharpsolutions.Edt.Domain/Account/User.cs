using Sharpsolutions.Edt.System.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Domain.Account {
    public class User: IEntity {

        private User() { 
            
        }

        public User(string Name, Password pwd) {
            this.Name = Name;
            this.Password = pwd;
        }

        
        public virtual string Name { get; protected set; }
        
        public virtual Password Password { get; protected set; }

        public bool Verify(string password) {
            return this.Password.Equals(password);
        }

        public static User Create(string userName, string pwd) {
            User u = new User(userName, Password.New(pwd));
            

            return u;
        }

            

        
    }
}
