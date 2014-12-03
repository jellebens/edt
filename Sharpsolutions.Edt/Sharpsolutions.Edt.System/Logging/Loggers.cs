using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Logging {
    public static class Loggers {
        private const string Base = "Edit.";

        public static class Security { 
            public const string Sec = Base + "Security";
            public const string Authentication = Sec + "Authentication";
        }

        public static class Commanding { 
            private const string Command = Base + "Commading.";
            public const string Producer = Command + "Producer";
            public const string Worker = Command + "Worker";
        }
    }
}
