using NUnit.Framework;
using Sharpsolutions.Edt.Domain.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Domain.Tests.Account {
    [TestFixture]
    public class PasswordTests {
        [Test]
        public void EqualsHavingSamePasswordShouldBeTrue(){
            
            Password pwd = Password.New("P@ssw0rd");

            Assert.AreEqual("P@ssw0rd", pwd);
        }

        [Test]
        public void EqualsHavingDifferentShouldBeFalse() {

            Password pwd = new Password("P@ssw0rd");

            Assert.AreNotEqual("P@", pwd);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CtorWithEmptyStringThrowsArgumentNullException() {
            new Password("");
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CtorWithNullStringThrowsArgumentNullException() {
            new Password(null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CtorWithSpacesStringThrowsArgumentNullException() {
            new Password(" ");
        }
    }
}
