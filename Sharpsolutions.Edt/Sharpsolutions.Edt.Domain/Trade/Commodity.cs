using System;
using System.Runtime.InteropServices.WindowsRuntime;
using Sharpsolutions.Edt.System.Domain;

namespace Sharpsolutions.Edt.Domain.Trade {
    public class Commodity: IEntity {
        private Commodity() {

        }

        public virtual Guid Id { get; protected set; }

        public Commodity(string name, string category) {
            this.Name = name;
            this.Category = new Category(category);
        }

        public string Name { get; protected set; }
        public Category Category { get; protected set; }

        public static bool operator ==(Commodity left, Commodity right)
        {
            if ((object) left == null && (object)right != null)
            {
                return false;
            }

            return left.Equals(right);
        }

        public static bool operator !=(Commodity left, Commodity right)
        {
            return !(left == right);
        }

        public class CommodityFactory {
            public static Commodity Create(string commodity, Category category) {
                if (string.IsNullOrWhiteSpace(commodity)) { throw new ArgumentNullException("commodity"); }
                if (category == null) { throw new ArgumentNullException("category"); }

                Commodity cmdty = new Commodity
                {
                    Category = category, 
                    Name = commodity
                };


                return cmdty;
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType()) {
                return false;
            }

            Commodity other = obj as Commodity;
            if (other == null) {
                return false;
            }
            bool nameSame = string.Equals(this.Name, other.Name, StringComparison.InvariantCultureIgnoreCase);
            bool categorySame = this.Category.Equals(other.Category);
            return nameSame && categorySame;
        }
    }
}
