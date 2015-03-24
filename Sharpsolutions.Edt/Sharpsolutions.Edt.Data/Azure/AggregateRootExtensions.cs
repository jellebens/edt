using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.System.Domain;

namespace Sharpsolutions.Edt.Data.Azure {
    public static class AggregateRootExtensions {
        public static string PartitionKey(this AgregateRootBase entity)
        {
            return string.Format("{0}_{1}", entity.GetType(), entity.Id);
        }
    }
}
