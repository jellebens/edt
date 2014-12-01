using Sharpsolutions.Edt.System.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Domain.Account {
    public class User: IEntity<string> {
        public virtual string UserName { get; protected set; }
        public virtual string Id { get; protected set; }

        public virtual string PwdHash { get; protected set; }


        public static User Create(string userName, string pwd) {
            User u = new User();
            u.UserName = userName;
            u.Id = userName;

            byte[] hash = SHA256Managed.Create().ComputeHash(ASCIIEncoding.ASCII.GetBytes(pwd));
            u.PwdHash = ASCIIEncoding.ASCII.GetString(hash);

            return u;
        }

        
    }
}
