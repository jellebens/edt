using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Castle.Core.Logging;
using Sharpsolutions.Edt.Monitor.Models;
using Sharpsolutions.Edt.System.Logging;

// ReSharper disable All

namespace Sharpsolutions.Edt.Monitor.System {
    public class NetLog
    {
        private readonly string _directory;
        private readonly ILogger _logger;

        public NetLog(string directory, ILoggerFactory loggerFactory)
        {
            _directory = directory;
            _logger = loggerFactory.Create(Loggers.Monitor.Parse);
        }

        public SystemModel[] Process()
        {
            Dictionary<string, SystemModel> results = new Dictionary<string, SystemModel>();

            if (!Directory.Exists(_directory))
            {
                throw new InvalidOperationException(string.Format("Directory {0} does not exists", _directory));
            }

            IEnumerable<string> files = Directory.EnumerateFiles(_directory, "*.log");

            foreach (string file in files)
            {
                using (StreamReader reader = File.OpenText(file))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null) {
                        try
                        {
                            SystemModel model = NetLogLine.Parse(line);
                            if (model != null) {
                                if (results.ContainsKey(model.Name)) {
                                    _logger.InfoFormat("Allready found system {0}", model.Name);
                                } else {
                                    results.Add(model.Name, model);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            _logger.FatalFormat("Failed to parse line: {0}", line);
                            throw;
                        }
                    }
                }
            }

            return results.Values.ToArray();
        }
    }

    public static class NetLogLine
    {
        public static SystemModel Parse(string line)
        {
            if (line.Contains("System") && line.Contains("Pos"))
            {
                string system = ParseSystem(line);

                Dictionary<char, double> coordinates = ParsePos(line);
                
                return new SystemModel()
                {
                    Name = system,
                    X = coordinates['x'],
                    Y = coordinates['y'],
                    Z = coordinates['z']
                };
            }
            else
            {
                return null;
            }
        }

        private static Dictionary<char, double> ParsePos(string position)
        {
            Regex posRegex = new Regex(@"\(([0-9\-e+\.]+),([0-9\-e+\.]+),([0-9\-e+\.]+)\)");

            Match positionMatch = posRegex.Match(position);

            Regex coordinateRegex = new Regex(@"([0-9\-e+\.]+)");

            MatchCollection matches = coordinateRegex.Matches(positionMatch.Value);

            Dictionary<char, double> coordinates = new Dictionary<char, double>()
            {
                {'x', double.Parse(matches[0].Value, NumberStyles.Float, CultureInfo.InvariantCulture) },
                {'y', double.Parse(matches[1].Value, NumberStyles.Float, CultureInfo.InvariantCulture) },
                {'z', double.Parse(matches[2].Value, NumberStyles.Float, CultureInfo.InvariantCulture) }
            };

            return coordinates;
        }

        private static string ParseSystem(string systemPart)
        {
            Regex systemRegex = new Regex(@"System:[0-9]+\(([A-Za-z\ ]+)\)");

            Match m = systemRegex.Match(systemPart);

            string system = m.Groups[1].Value;
            return system;
        }
    }
}
