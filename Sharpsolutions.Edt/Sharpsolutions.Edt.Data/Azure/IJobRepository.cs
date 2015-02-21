using Sharpsolutions.Edt.System.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Data.Azure {
    public interface IJobRepository {
        void Add(Job job);
        Job Get(Guid commandId);
    }
}
