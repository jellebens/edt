using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.System;

namespace Sharpsolutions.Edt.Domain.Core {
    public class Length :Enumeration {
        public static  Length Km = new Length(1, "Km");
        public static Length Mm = new Length(2, "Mm");
        public static Length Ls =new Length(3, "Ls");
        public static Length Ly =new Length(3, "Ly");

        public Length(int value, string displayName) : base(value, displayName)
        {
            
        }
    }
}
