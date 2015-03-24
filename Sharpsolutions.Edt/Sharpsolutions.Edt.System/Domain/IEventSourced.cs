using System.Collections.Generic;

namespace Sharpsolutions.Edt.System.Domain {
    public interface IEventSourced
    {
        void ClearPendingChanges();

        void Load<TEvent>(IEnumerable<TEvent> events)
            where TEvent : EventBase;
    }
}
