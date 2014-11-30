using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System {
    public class Constants {
        public static class Bus {
            public const string ConfigName = "Edt.ServiceBus.ConnectionString";
            public static class Queue {
                public const string SendCommand = "edt-command-out";
            }
        }
    }
}
