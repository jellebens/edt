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
    public class UserRepositoryTests {
        readonly UserRepository _repository = new UserRepository();

        [TestFixtureSetUp]
        public void FixtureSetup() {

        }

        [Test]
        public void TestEmulator() {
            Emulator e = new Emulator();

            Assert.IsTrue(e.IsRunning);
        }

        [SetUp]
        public void SetUp() {
            new Emulator();
        }

        [Test]
        public void AddHavingAUserShouldNotThrow() {
            User u = User.Create("admin", "P@ssw0rd");

            _repository.CommitChanges(u);
        }

        [Test]
        public void RetrievingUserShouldNotThrow() {
            Setup(_repository);

            User expected = _repository.Get("admin");

            Assert.NotNull(expected);
            Assert.IsTrue(expected.Verify("P@ssw0rd"));
            _repository.CommitChanges(expected);
        }

        private void Setup(UserRepository repository) {
            User x = repository.Get("admin");

            if (x == null) {
                User u = User.Create("admin", "P@ssw0rd");
                repository.CommitChanges(u);
            }
        }
    }
}
