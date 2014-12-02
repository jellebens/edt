using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using NUnit.Framework;
using Sharpsolutions.Edt.Data.Azure;
using Sharpsolutions.Edt.Domain.Account;
using Sharpsolutions.Edt.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Data.Tests.Azure {
    [TestFixture]
    public class UserTableStoreRepositoryTests {
    
        [Test]
        public void AddHAvingAUserShouldNotThrow(){
            UserTableStoreRepository repository = new UserTableStoreRepository();

            User u = User.Create(Guid.NewGuid().ToString(), "P@ssw0rd");

            repository.Add(u);
        }
    }
}
