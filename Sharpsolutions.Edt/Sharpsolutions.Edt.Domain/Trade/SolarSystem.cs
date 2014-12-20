using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;

namespace Sharpsolutions.Edt.Domain.Trade {
    public class SolarSystem
    {
        protected SolarSystem()
        {

        }

        public SolarSystem(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
        public Guid Id { get; set; }

        public static bool operator ==(SolarSystem left, SolarSystem right) {
            if (object.ReferenceEquals(left, null)) {
                return ReferenceEquals(right, null);
            }

            return left.Equals(right);
        }

        public static bool operator !=(SolarSystem left, SolarSystem right) {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj) {
            SolarSystem other = obj as SolarSystem;
            if (other == null) {
                return false;
            }
            bool nameSame = string.Equals(this.Name, other.Name, StringComparison.InvariantCultureIgnoreCase);
            
            return nameSame;
        }
    }
}
