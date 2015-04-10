using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.System;

namespace Sharpsolutions.Edt.Domain.Core {
    public class Size: Enumeration {
        public static Size S = new Size(1, "S");
        public static Size M = new Size(2, "M");
        public static Size L = new Size(3, "L");

        public Size(int value, string displayName) : base(value, displayName)
        {

        }
    }
}
