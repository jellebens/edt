namespace Sharpsolutions.Edt.Data.Tests.Eddb.Models
{
    public class System
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public string Faction { get; set; }
        public long? Population { get; set; }
        public string Government { get; set; }
        public string Allegiance { get; set; }
        public object State { get; set; }
        public object Security { get; set; }
        public string PrimaryEconomy { get; set; }
        public int NeedsPermit { get; set; }
        public int UpdatedAt { get; set; }
    }
}
