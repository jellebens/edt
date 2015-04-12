using Sharpsolutions.Edt.Contracts.Data.Eddb;

namespace Sharpsolutions.Edt.Data.Eddb
{
    public class StationWebImport : WebImportBase<Station>
    {
        public StationWebImport() : base("stations.json")
        {

        }
    }
}
