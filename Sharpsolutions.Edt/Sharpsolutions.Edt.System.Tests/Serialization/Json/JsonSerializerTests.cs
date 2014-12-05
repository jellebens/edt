using NUnit.Framework;
using Sharpsolutions.Edt.Contracts.Command.Account;
using Sharpsolutions.Edt.System.Command;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Serialization.Json {
    [TestFixture]
    public class JsonSerializerFactoryTests {
        [Test]
        public void SerializeRegisterUserShouldNotThrow() {
            RegisterUser cmd = RegisterUser.New("John Doe", "P@ssw0rd");

            DataContractJsonSerializer serializer = JsonSerializerFactory.Create(cmd);
        }
    }
}
