using Sharpsolutions.Edt.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Domain.Trade {
    public class Economy: Enumeration {
        public static Economy Extraction = new Economy(1, "Extraction");
        public static Economy Refinery = new Economy(2, "Refinery");
        public static Economy Agriculture = new Economy(3, "Agriculture");
        public static Economy Industrial = new Economy(4, "Industrial");
        public static Economy HighTech = new Economy(5, "High Tech");

        protected Economy()
        {
        }

        public Economy(int value, string displayName): base(value, displayName)
        {
            
        }

        public static IEnumerable<Economy> All(){
            return All<Economy>();
        }

        public static Economy Parse(string economy)
        {
            return All().Single(e => e.DisplayName == economy);
        }
    }
}
