using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Contracts.Data.Eddb;

namespace Sharpsolutions.Edt.Data.Eddb {
    public class SystemWebImport : WebImportBase<SolarSystemDto>
    {
        public SystemWebImport() : base("systems.json")
        {

        }
    }
}
