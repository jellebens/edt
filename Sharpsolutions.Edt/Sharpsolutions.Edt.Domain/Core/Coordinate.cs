using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Domain.Core {
    public struct Coordinate
    {
        public static Coordinate None = new Coordinate(0,0,0);
        private double _x;
        private double _y;
        private double _z;

        public double x { get { return _x; } }
        public double y { get { return _y; } }
        public double z { get { return _z; } }

        public Coordinate(double x, double y, double z) {
            _x = x;
            _y = y;
            _z = z;
        }
    }
}
