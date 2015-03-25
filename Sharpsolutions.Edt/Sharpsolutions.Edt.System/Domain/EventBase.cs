using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Domain {
    public interface IEvent
    {
        long Version { get; set; }
    }
    
    public abstract class EventBase : IEvent {
        protected EventBase()
        {
            Timestamp = DateTime.UtcNow;
        }

        public DateTime Timestamp { get; set; }

        public long Version { get; set; }
    }
}
