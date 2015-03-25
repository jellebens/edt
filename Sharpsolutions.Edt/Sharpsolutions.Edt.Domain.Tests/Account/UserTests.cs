    using NUnit.Framework;
using Sharpsolutions.Edt.Domain.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Domain.Tests.Account {
    [TestFixture]
    public class UserTests {

        [Test]
        public void PendingEventsShouldGetPendingEvents()
        {
            User u = User.Create("John doe", "pass");
            
            Assert.AreEqual(1, u.PendingChanges.Count);
        }

        [Test]
        public void VerifyHavingCorrectPasswordShouldReturnTrue() {
            string pass = "P@ssw0rd";
            User u = Setup(pass);

            Console.WriteLine(u.Password);

            bool isValid = u.TryLogin(pass);
            Assert.IsTrue(isValid);
        }

        [Test]
        public void VerifyHavingIncorrectPasswordShouldReturnFalse() {
            User u = Setup();

            bool isValid = u.TryLogin("HEllo");
            Assert.IsFalse(isValid);
            Assert.AreEqual(1, u.InvalidAttempts);
        }
        

        [Test]
        public void VerifyHavingIncorrectPasswordTwiceShouldIncrement() {
            User u = Setup();

            u.TryLogin("Hello");
            u.TryLogin("Hello");

            Assert.AreEqual(2, u.InvalidAttempts);
            Assert.AreEqual(3, u.Version);
        }

        private static User Setup() {
            string pass = "P@ssw0rd";
            return Setup(pass);
        }

        private static User Setup(string pass)
        {
            User u = User.Create("John doe", pass);
            return u;
        }

        [Test]
        public void CreateNewShouldCreateANewUserAndVersionShouldBeOne()
        {
            User u = Setup();

            Assert.AreEqual(1, u.Version);
        }
    }
}
