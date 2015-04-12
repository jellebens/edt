using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;
using Newtonsoft.Json;
using Sharpsolutions.Edt.Domain.Trade;
using Sharpsolutions.Edt.System.Domain;

namespace Sharpsolutions.Edt.Data.Azure {
    public class StarportRepository : TableStorageBase<Starport>, IRepository<Starport>
    {
        protected override string Table { get { return "starports"; } }
        
        protected override string GetPartitionKey(Starport root)
        {
            return string.Concat(root.System.Name, root.Name);
        }

        public Starport Get(string id)
        {
            throw new NotImplementedException();
        }
    }
}
