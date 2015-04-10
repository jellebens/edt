using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sharpsolutions.Edt.System.UnitTests.NUnit {
    public class UnitTestAttribute : CategoryAttribute {
        public UnitTestAttribute() : base("Unit Test") {
        }
    }
}
