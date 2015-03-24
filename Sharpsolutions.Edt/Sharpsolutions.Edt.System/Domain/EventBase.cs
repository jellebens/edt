using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Domain {
    public interface IEvent
    {
        long Version { get; set; }
    }

    public abstract class EventBase : IEvent {
        public long Version { get; set; }
    }
}
