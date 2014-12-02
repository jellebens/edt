using Microsoft.WindowsAzure.Storage.Table;
using Sharpsolutions.Edt.Domain.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Data.Azure.Mappers {
    public class UserEntity: TableEntity {
        public UserEntity(User u) {
            this.PartitionKey = string.Format("{0:yyyyMM}_{1}", DateTime.UtcNow, u.UserName);
            this.RowKey = u.UserName;
            this.PwdHash = u.PwdHash;
        }

        public string Id { get; set; }
        public string UserNames { get; set; }
        public string PwdHash { get; set; }
    }
}
