using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using Sharpsolutions.Edt.Contracts.Command.Trade;
using Sharpsolutions.Edt.Contracts.Data.Eddb;
using Sharpsolutions.Edt.Data.Azure;
using Sharpsolutions.Edt.Data.Eddb;
using Sharpsolutions.Edt.Domain.Core;
using Sharpsolutions.Edt.Domain.Trade;
using Sharpsolutions.Edt.System.Command;
using Sharpsolutions.Edt.System.Data;
using Sharpsolutions.Edt.System.Logging;

namespace Sharpsolutions.Edt.Handler.Command.Trade {
    public class ImportStarportsHandler: CommandHandlerBase<ImportStarports> {
        private readonly IWebImport<Station> _source;
        private readonly IWebImport<SolarSystemDto> _solarsystems;
        private readonly IRepository<Starport> _destination;
        private readonly ILogger _logger;

        public ImportStarportsHandler(IWebImport<Station> stations, IWebImport<SolarSystemDto> solarsystems, IRepository<Starport> destination,ILoggerFactory loggerFactory) {
            _source = stations;
            _solarsystems = solarsystems;
            _destination = destination;
            _logger = loggerFactory.Create(Loggers.Import.Eddb);
        }
        
        public override void Execute(ImportStarports command)
        {
            Stopwatch stopwatch = new Stopwatch();
            
            IDictionary<int, SolarSystemDto> solarSystems = _solarsystems.Load().ToDictionary(x => x.id);
            
            _logger.InfoFormat("Loaded solar systems {0:N} ms", stopwatch.ElapsedMilliseconds);
            stopwatch.Restart();

            IList<Station> stations = _source.Load();

            _logger.InfoFormat("Loaded stations {0:N} ms", stopwatch.ElapsedMilliseconds);
            stopwatch.Restart();
            
            Parallel.ForEach(stations, (station, state, arg3) =>
            {
                SolarSystemDto solarSystemDto;

                if (solarSystems.TryGetValue(station.system_id, out solarSystemDto))
                {
                    Coordinate position;

                    if (solarSystemDto.x.HasValue && solarSystemDto.y.HasValue && solarSystemDto.z.HasValue)
                    {
                        position = new Coordinate(solarSystemDto.x.Value, solarSystemDto.y.Value, solarSystemDto.z.Value);
                    }
                    else
                    {
                        position = Coordinate.None;
                    }
                    
                    SolarSystem system = new SolarSystem(solarSystemDto.name, position);

                    StarportBuilder builder = new StarportBuilder(station.name, system);

                    Starport starport = builder.Build();

                    _destination.CommitChanges(starport);
                }
                else
                {
                    _logger.WarnFormat("Can not create station {0} solar system with id {1} not found", station.name, station.system_id);
                }
            });

            _logger.InfoFormat("Saved Starports {0:N} ms", stopwatch.ElapsedMilliseconds);
            stopwatch.Restart();

        }
    }
}
