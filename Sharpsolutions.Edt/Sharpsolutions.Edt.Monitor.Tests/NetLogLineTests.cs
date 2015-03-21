using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Sharpsolutions.Edt.Monitor.Models;
using Sharpsolutions.Edt.Monitor.System;

namespace Sharpsolutions.Edt.Monitor.Tests {
    [TestFixture]
    public class NetLogLineTests
    {
        [Test]
        public void ParseSystemNameTest()
        {
            Regex systemRegex = new Regex(@"System:[0-9]+\(([A-Za-z]+)\)$");

            string systemPart = "System:6(Styx)";

            Match m = systemRegex.Match(systemPart);

            Assert.AreEqual("Styx", m.Groups[1].Value);
        }

        [Test]
        public void ParsePosTest()
        {
            string posPart = "Pos:(-9.46644e+007,2.8448e+008,3.54308e+008)";


            Regex posRegex = new Regex(@"([0-9\-.e+]+)");

            MatchCollection matches = posRegex.Matches(posPart);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

            Assert.AreEqual(matches.Count, 3);
        }

        [Test]
        public void ParseCoordinateTest()
        {
            const double expected = -9.46644e+007;
            const string input = "-9.46644e+007";

            double actual = double.Parse(input, NumberStyles.Float, CultureInfo.InvariantCulture);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ParseLineWithSpaceInSystemName()
        {
            string line = "{17:22:05} System:37(i Bootis) Body:1 Pos:(3.87388e+009,-8.69364e+009,-1.32627e+010) cruising";

            SystemModel expected = new SystemModel()
            {
                X = 3.87388e+009,
                Y = -8.69364e+009,
                Z = -1.32627e+010,
                Name = "i Bootis"
            };

            SystemModel actual = NetLogLine.Parse(line);

            AssertSystem(expected, actual);
        }

        [Test]
        public void ParseLineNotHavingEButDecimals() {
            string line = "{16:39:08} System:21(Aulin) Body:15 Pos:(-3792.54,-2961.36,-17592.9) ";

            SystemModel expected = new SystemModel()
            {
                X = -3792.54,
                Y = -2961.36,
                Z = -17592.9,
                Name = "Aulin"
            };

            SystemModel actual = NetLogLine.Parse(line);

            AssertSystem(expected, actual);
        }



        [Test]
        public void ParseLineShouldParse()
        {
            SystemModel expected = new SystemModel()
            {
                X = -9.46644e+007,
                Y = 2.8448e+008,
                Z = 3.54308e+008,
                Name = "Styx"
            };

            string line = "{22:25:39} System:6(Styx) Body:0 Pos:(-9.46644e+007,2.8448e+008,3.54308e+008)";

            SystemModel actual = NetLogLine.Parse(line);

            AssertSystem(expected, actual);
        }

        private static void AssertSystem(SystemModel expected, SystemModel actual)
        {
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.X, actual.X);
            Assert.AreEqual(expected.Y, actual.Y);
            Assert.AreEqual(expected.Z, actual.Z);
        }

        [Test]
        public void TryParseShouldReturnTrue()
        {
            string line = "{20:06:10} machines=6&numturnlinks=1&backlogtotal=0&backlogmax=0&avgsrtt=107&loss=0.008&&jit=2.020";

            SystemModel actual = NetLogLine.Parse(line);

            Assert.IsNull(actual);
        }
    }
}
