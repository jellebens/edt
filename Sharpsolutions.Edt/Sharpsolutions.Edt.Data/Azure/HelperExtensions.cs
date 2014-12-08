using Sharpsolutions.Edt.Domain.Trade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Data.Azure {
    public static class HelperExtensions {
        public static TableKey Id(this Starport starport)
        {
            return new TableKey(starport.System.Name.ToLower(), starport.Name.ToLower());
        }
    }
}
