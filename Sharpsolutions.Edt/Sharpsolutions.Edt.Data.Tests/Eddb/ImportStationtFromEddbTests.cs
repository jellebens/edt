using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NUnit.Framework;
using Sharpsolutions.Edt.Data.Tests.Eddb.Models;
using Sharpsolutions.Edt.System.UnitTests.NUnit;

namespace Sharpsolutions.Edt.Data.Tests.Eddb {
    [TestFixture]
    public class ImportStationtFromEddbTests {
        [Test, IntegrationTest]
        public void ImportShouldLoadStarports() {
            using (WebClient client = new WebClient()) {
                client.BaseAddress = "http://eddb.io/";

                byte[] data = client.DownloadData("archive/v3/stations.json");
                using (MemoryStream ms = new MemoryStream(data)) {

                    using (StreamReader sr = new StreamReader(ms)) {
                        using (JsonReader reader = new JsonTextReader(sr)) {
                            JsonSerializer serializer = new JsonSerializer();

                            List<Station> stations = serializer.Deserialize<List<Station>>(reader);
                            Console.WriteLine("Found {0} stations" , stations.Count);
                            Assert.AreNotEqual(0, stations.Count);
                        }
                    }
                }

            }
        }
    }
}

