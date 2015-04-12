using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;

namespace Sharpsolutions.Edt.System.Castle {
    public class ConsoleLoggerFactory : ILoggerFactory {
        public ILogger Create(Type type)
        {
            return Create(type.FullName);
        }

        public ILogger Create(string name)
        {
            return new ConsoleLogger(name);
        }

        public ILogger Create(Type type, LoggerLevel level)
        {
            return Create(type.FullName, level);
        }

        public ILogger Create(string name, LoggerLevel level)
        {
            return new ConsoleLogger(name, level);
        }
    }
}
