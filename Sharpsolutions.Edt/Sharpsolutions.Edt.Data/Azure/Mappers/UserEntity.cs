using Microsoft.WindowsAzure.Storage.Table;
using Sharpsolutions.Edt.Domain.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Data.Azure.Mappers {
    public class UserEntity : TableEntity {
        private class aUser : User {
            
            public override string Id { get; protected set; }
            public override string PwdHash { get; protected set; }
            public override string UserName { get; protected set; }

            public static User Map(UserEntity ent) {
                aUser result = new aUser() {
                    Id = ent.Id,
                    PwdHash = ent.PwdHash,
                    UserName = ent.UserName
                };
                return result;
            }
        }

        public UserEntity(User u) {
            this.PartitionKey = u.UserName;
            this.RowKey = u.UserName;
            this.UserName = u.UserName;
            this.PwdHash = u.PwdHash;
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string PwdHash { get; set; }

        internal User AsDomain() {
            return aUser.Map(this);
        }
    }
}
