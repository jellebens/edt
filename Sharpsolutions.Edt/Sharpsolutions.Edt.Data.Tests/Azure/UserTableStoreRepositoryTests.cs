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
        UserTableStoreRepository _Repository = new UserTableStoreRepository();

        [Test]
        public void AddHAvingAUserShouldNotThrow(){
            User u = User.Create(Guid.NewGuid().ToString(), "P@ssw0rd");
            
            _Repository.Add(u);
        }

        [Test]
        public void RetrievingUserShouldNotThrow() {
            Setup(_Repository);

            User expected = _Repository.Get("admin");

            Assert.NotNull(expected);
            Assert.IsTrue(expected.Verify("P@ssw0rd"));
            
        }

        private void Setup(UserTableStoreRepository repository) {
            User x = repository.Get("admin");

            if (x == null) {
                User u = User.Create("admin", "P@ssw0rd");
                repository.Add(u);
            }
        }
    }
}
