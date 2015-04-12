using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NUnit.Framework;
using Sharpsolutions.Edt.Contracts.Data.Eddb;
using Sharpsolutions.Edt.Data.Eddb;
using Sharpsolutions.Edt.System.UnitTests.NUnit;

namespace Sharpsolutions.Edt.Data.Tests.Eddb {
    [TestFixture]
    public class ImportStationFromEddbTests {
        [Test, IntegrationTest]
        public void ImportShouldLoadStarports() {
            StationWebImport import = new StationWebImport();

            IList<Station> stations = import.Load();

            Assert.IsNotNull(stations);
        }
    }
}

