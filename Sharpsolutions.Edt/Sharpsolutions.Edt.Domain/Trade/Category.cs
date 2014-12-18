using System;

namespace Sharpsolutions.Edt.Domain.Trade {
    public class Category: IEquatable<string> {

        protected Category()
        {

        }

        public Category(string name) {
            if (string.IsNullOrWhiteSpace(name)) {
                throw new ArgumentNullException(name);
            }

            this.Name = name;
        }

        public virtual Guid Id { get; set; }

        public virtual string Name { get; set; }

        public override string ToString() {
            return Name;
        }

        public override bool Equals(object obj) {
            Category other = obj as Category;
            if(other == null){
                return false;
            }

            return this.Name == other.Name;
        }

        public override int GetHashCode() {
            return Name.GetHashCode();
        }

        public bool Equals(string other) {
            return this.Name.Equals(other);
        }

        
    }
}
