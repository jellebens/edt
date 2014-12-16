using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Domain.Core {
    /// <summary>
    /// This class is used to replace the default .NET enum types
    /// Since imo they violate the Open Closed principle
    /// More info: http://en.wikipedia.org/wiki/SOLID_%28object-oriented_design%29
    /// 
    /// Based on:
    /// http://lostechies.com/jimmybogard/2008/08/12/enumeration-classes/
    /// </summary>
    [Serializable]
    public abstract class Enumeration : IComparable {
        private int _value;
        private string _displayName;

        protected Enumeration() {
        }

        protected Enumeration(int value, string displayName) {
            _value = value;
            _displayName = displayName;
        }

        public virtual int Value {
            get { return _value; }
            protected set { _value = value; }
        }

        public virtual string DisplayName {
            get { return _displayName; }
            protected set { _displayName = value; }
        }

        public override string ToString() {
            return DisplayName;
        }

        public override bool Equals(object obj) {
            var otherValue = obj as Enumeration;

            if (otherValue == null) {
                return false;
            }

            var typeMatches = obj is Economy;
            var valueMatches = _value.Equals(otherValue.Value);

            return typeMatches && valueMatches;
        }

        public override int GetHashCode() {
            return _value.GetHashCode();
        }

        public virtual int CompareTo(object other) {
            return Value.CompareTo(((Enumeration)other).Value);
        }

        public static IEnumerable<TEnum> All<TEnum>() {

            FieldInfo[] staticFields = typeof(TEnum).GetFields(BindingFlags.Public | BindingFlags.Static);

            List<TEnum> all = new List<TEnum>();
            foreach (FieldInfo field in staticFields) {
                all.Add((TEnum)field.GetValue(null));
            }

            return all;
        }
    }
}
