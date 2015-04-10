using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Domain.Core {
    public class Distance {
        public Distance(double distance, Length unit)
        {
            Value = distance;
            Unit = unit;
        }

        public Length Unit { get; private set; }

        public double Value { get; private set; }
    }
}
