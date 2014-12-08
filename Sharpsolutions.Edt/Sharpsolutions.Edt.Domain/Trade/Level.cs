using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Domain.Core;

namespace Sharpsolutions.Edt.Domain.Trade {
    public class Level: Enumeration {
        public static Level High = new Level(1, "High", 'H' );
        public static Level Medium = new Level(1, "Medium", 'M');
        public static Level Low = new Level(1, "Low", 'L');

        public Level(int value, string name, char key):base(value, name)
        {
            this.Key = key;
        }

        public char Key { get; private set; }
    }
}
