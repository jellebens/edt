using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.System.Domain;

namespace Sharpsolutions.Edt.Data.Azure {
    public interface IRepository<TRoot> where TRoot : AgregateRootBase {
        void CommitChanges(TRoot root);
        TRoot Get(string id);
    }
}
