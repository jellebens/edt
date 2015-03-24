using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Domain.Account {
    public class Password: IEquatable<string> {
        private const string _val = "CEAB5083-D28A-417E-A49F-C7B01E691119";
        private string _Hash;
        public Password() {

        }

        public Password(string hash) {
            if (string.IsNullOrWhiteSpace(hash)) {
                throw new ArgumentNullException("Password can not be null or empty");
            }

            _Hash = hash;
        }

        public string Hash {
            get { return _Hash; }
        }

        public static Password New(string pwd) {
            if (string.IsNullOrWhiteSpace(pwd)) {
                throw new ArgumentNullException("Password can not be null or empty");
            }
            Password password = new Password();
            password._Hash = password.Calculate(pwd);

            return password;
        }

        private string Calculate(string pwd) {
            string hash;
            ASCIIEncoding encoding = new ASCIIEncoding();
            string secret = typeof(User).Name;

            byte[] keyByte = encoding.GetBytes(_val);
            
            byte[] messageBytes = encoding.GetBytes(pwd);
            using (var hmacsha256 = new HMACSHA256(keyByte)) {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                hash = Convert.ToBase64String(hashmessage);
            }
            return hash;
        }

        public bool Equals(string other) {
            return string.Equals(_Hash, Calculate(other));
        }

        public override string ToString() {
            return _Hash;
        }

        public override int GetHashCode() {
            return _Hash.GetHashCode();
        }
    }
}
