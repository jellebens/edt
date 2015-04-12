using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sharpsolutions.Edt.Contracts.Data.Eddb;
using Sharpsolutions.Edt.Data.Eddb;
using Sharpsolutions.Edt.System.UnitTests.NUnit;

namespace Sharpsolutions.Edt.Data.Tests.Eddb {
    [TestFixture]
    public class ImportSystemFromEddbTests {
        [Test, IntegrationTest]
        public void ImportShouldLoadAllSystems()
        {
            SystemWebImport import = new SystemWebImport();

            IList<SolarSystemDto> systems = import.Load();

            Assert.IsNotNull(systems);
        }
    }
}
