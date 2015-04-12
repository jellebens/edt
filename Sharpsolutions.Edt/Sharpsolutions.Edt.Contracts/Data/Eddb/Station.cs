using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Sharpsolutions.Edt.Contracts.Data.Eddb
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class Station
    {
        public int id { get; set; }
        public string name { get; set; }
        public int system_id { get; set; }
        public string max_landing_pad_size { get; set; }
        public int? distance_to_star { get; set; }
        public string faction { get; set; }
        public object government { get; set; }
        public object allegiance { get; set; }
        public object state { get; set; }
        public string type { get; set; }
        public object has_blackmarket { get; set; }
        public int? has_commodities { get; set; }
        public int? has_refuel { get; set; }
        public int? has_repair { get; set; }
        public int? has_rearm { get; set; }
        public int? has_outfitting { get; set; }
        public int? has_shipyard { get; set; }
        public List<string> import_commodities { get; set; }
        public List<string> export_commodities { get; set; }
        public List<string> prohibited_commodities { get; set; }
        public List<string> economies { get; set; }
        public int updated_at { get; set; }
        public List<Listing> listings { get; set; }
    }
}
