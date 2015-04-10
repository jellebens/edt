using System.Collections.Generic;

namespace Sharpsolutions.Edt.Data.Tests.Eddb.Models
{
    public class Station
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SystemId { get; set; }
        public string MaxLandingPadSize { get; set; }
        public int? DistanceToStar { get; set; }
        public string Faction { get; set; }
        public object Government { get; set; }
        public object Allegiance { get; set; }
        public object State { get; set; }
        public string Type { get; set; }
        public object HasBlackmarket { get; set; }
        public int? HasCommodities { get; set; }
        public int? HasRefuel { get; set; }
        public int? HasRepair { get; set; }
        public int? HasRearm { get; set; }
        public int? HasOutfitting { get; set; }
        public int? HasShipyard { get; set; }
        public List<string> ImportCommodities { get; set; }
        public List<string> ExportCommodities { get; set; }
        public List<string> ProhibitedCommodities { get; set; }
        public List<string> Economies { get; set; }
        public int UpdatedAt { get; set; }
        public List<Listing> Listings { get; set; }
    }
}
