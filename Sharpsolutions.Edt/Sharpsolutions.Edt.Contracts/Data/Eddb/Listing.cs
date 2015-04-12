using System.Diagnostics.CodeAnalysis;

namespace Sharpsolutions.Edt.Contracts.Data.Eddb
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class Listing
    {
        public int id { get; set; }
        public int station_id { get; set; }
        public int commodity_id { get; set; }
        public int supply { get; set; }
        public int buy_price { get; set; }
        public int sell_price { get; set; }
        public int demand { get; set; }
        public int collected_at { get; set; }
        public int update_count { get; set; }
    }


}
