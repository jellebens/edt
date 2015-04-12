using System;
using Sharpsolutions.Edt.Domain.Trade;

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
