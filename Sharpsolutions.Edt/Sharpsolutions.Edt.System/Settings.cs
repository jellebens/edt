using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System {
    public class Settings {
        public static class Storage{
            public static class Table { 
                public const string ConfigKey="Edt.Storage.TableStore";
            }
            
        }

        public static class Bus {
            public const string ConfigKey = "Edt.ServiceBus.ConnectionString";
            
            public static class Queue {
                public const string SendCommand = "edt-command-out";
            }
        }
    }
}
