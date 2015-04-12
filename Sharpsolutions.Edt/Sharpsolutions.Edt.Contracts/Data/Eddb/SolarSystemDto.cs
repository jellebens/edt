using System.Diagnostics.CodeAnalysis;

namespace Sharpsolutions.Edt.Contracts.Data.Eddb
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class SolarSystemDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public double? x { get; set; }
        public double? y { get; set; }
        public double? z { get; set; }
        public string faction { get; set; }
        public long? population { get; set; }
        public string government { get; set; }
        public string allegiance { get; set; }
        public string state { get; set; }
        public string security { get; set; }
        public string primary_economy { get; set; }
        public int? needs_permit { get; set; }
        public int updated_at { get; set; }
    }
}
