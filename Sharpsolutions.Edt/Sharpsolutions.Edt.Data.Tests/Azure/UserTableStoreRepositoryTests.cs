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
            Console.WriteLine(u.PwdHash);
            repository.Add(u);
        }

        [Test]
        public void RetrievingUserShouldNotThrow() {
            UserTableStoreRepository repository = new UserTableStoreRepository();
            User x =  repository.Get("admin");
            Console.WriteLine(x.PwdHash);
            
            Assert.IsTrue(x.Verify("P@ssw0rd"));
            Assert.NotNull(x);
        }
    }
}
