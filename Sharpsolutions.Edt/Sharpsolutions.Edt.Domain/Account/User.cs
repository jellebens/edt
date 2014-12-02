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

        public bool Verify(string password) {
            string hash = CreateHash(password);

            return hash == this.PwdHash;
        }

        public static User Create(string userName, string pwd) {
            User u = new User();
            u.UserName = userName;
            u.Id = userName;

            u.PwdHash = u.CreateHash(pwd);

            return u;
        }

        private string CreateHash(string pwd) {
            string hash;
            ASCIIEncoding encoding = new ASCIIEncoding();
            string secret = this.GetType().Name;

            byte[] keyByte = encoding.GetBytes(secret);
            byte[] messageBytes = encoding.GetBytes(pwd);
            using (var hmacsha256 = new HMACSHA256(keyByte)) {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                hash = Convert.ToBase64String(hashmessage);
            }
            return hash;
        }

        
    }
}
