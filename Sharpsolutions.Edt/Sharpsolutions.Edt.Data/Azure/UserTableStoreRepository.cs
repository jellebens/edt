using Sharpsolutions.Edt.Domain.Account;
using Sharpsolutions.Edt.System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Data.Azure {
    public class UserTableStoreRepository: IRepository<User, string> {
        public void Add(User entity) {
            throw new NotImplementedException();
        }
    }
}
