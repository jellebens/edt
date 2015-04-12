using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
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
