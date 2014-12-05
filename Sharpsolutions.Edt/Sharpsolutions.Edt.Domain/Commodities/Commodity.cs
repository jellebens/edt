using Sharpsolutions.Edt.System.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Domain.Commodities {
    public class Commodity: IEntity<string> {
        private Commodity() {

        }

        public Commodity(string name, string category) {
            this.Name = name;
            this.Category = new Category(category);
        }

        public string Name { get; protected set; }
        public Category Category { get; protected set; }

        public class CommodityFactory {
            public static Commodity Create(string commodity, string category) {
                if (string.IsNullOrWhiteSpace(commodity)) { throw new ArgumentNullException("commodity"); }
                if (string.IsNullOrWhiteSpace(category)) { throw new ArgumentNullException("category"); }

                Commodity cmdty = new Commodity();

                cmdty.Category = new Category(category);
                cmdty.Name = commodity;

                return cmdty;
            }
        }



        public string Id {
            get { return this.Name.ToLower(); }
        }
    }
}
