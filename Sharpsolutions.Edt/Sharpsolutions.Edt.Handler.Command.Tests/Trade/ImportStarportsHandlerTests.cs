using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using NUnit.Framework;
using Sharpsolutions.Edt.Contracts.Command.Trade;
using Sharpsolutions.Edt.Data.Azure;
using Sharpsolutions.Edt.Data.Eddb;
using Sharpsolutions.Edt.Handler.Command.Trade;
using Sharpsolutions.Edt.System.Castle;
using Sharpsolutions.Edt.System.UnitTests.Azure;
using Sharpsolutions.Edt.System.UnitTests.NUnit;

namespace Sharpsolutions.Edt.Handler.Command.Tests.Trade {
    [TestFixture]
    public class ImportStarportsHandlerTests {
        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            Emulator.Start();
        }

        [Test, IntegrationTest]
        public void HandleShouldImportAllStations()
        {
            ImportStarports command = new ImportStarports();
            
            ImportStarportsHandler handler = new ImportStarportsHandler(new StationWebImport(), new SystemWebImport(), new StarportRepository(), new ConsoleLoggerFactory());

            handler.Execute(command);
        }
    }
}
