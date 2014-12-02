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
            User u = User.Create("John doe", pass);

            Console.WriteLine(u.PwdHash);

            bool isValid = u.Verify(pass);
            Assert.IsTrue(isValid);
        }

        [Test]
        public void VerifyHavingIncorrectPasswordShouldReturnFalse() {
            string pass = "P@ssw0rd";
            User u = User.Create("John doe", pass);

            Console.WriteLine(u.PwdHash);

            bool isValid = u.Verify("HEllo");
            Assert.IsFalse(isValid);
        }
    }
}
