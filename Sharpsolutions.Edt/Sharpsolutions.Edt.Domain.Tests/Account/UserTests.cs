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
        public void VerifyHavingCorrectPasswordShouldReturnTrue() {
            string pass = "P@ssw0rd";
            UUser u = Setup(pass);

            Console.WriteLine(u.Password);

            bool isValid = u.Verify(pass);
            Assert.IsTrue(isValid);
        }

        [Test]
        public void VerifyHavingIncorrectPasswordShouldReturnFalse() {
            UUser u = Setup();

            bool isValid = u.Verify("HEllo");
            Assert.IsFalse(isValid);
            Assert.AreEqual(1, u.InvalidAttempts);
        }

        [Test]
        public void VerifyHavingIncorrectPasswordTiceShouldIncrement() {
            UUser u = Setup();

            u.Verify("Hello");
            u.Verify("Hello");

            Assert.AreEqual(2, u.InvalidAttempts);
            Assert.AreEqual(3, u.Version);
        }

        private static UUser Setup() {
            string pass = "P@ssw0rd";
            return Setup(pass);
        }

        private static UUser Setup(string pass)
        {
            UUser u = UUser.Create("John doe", pass);
            return u;
        }

        [Test]
        public void CreateNewShouldCreateANewUserAndVersionShouldBeOne()
        {
            UUser u = Setup();

            Assert.AreEqual(1, u.Version);
        }
    }
}
