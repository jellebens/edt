using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using NUnit.Core;
using NUnit.Framework;
using Sharpsolutions.Edt.Monitor.Models;
using Sharpsolutions.Edt.Monitor.System;

namespace Sharpsolutions.Edt.Monitor.Tests {
    [TestFixture]
    public class NetLogTests
    {

        [Test]
        public void ProcessShouldProcessTheFile()
        {
            NetLog log = new NetLog(@"D:\workspaces\elite\edt\backup\logs", new ConsoleFactory());

            SystemModel[] results = log.Process();

            Assert.AreNotEqual(results.Length, 0);
        }
    }
}
