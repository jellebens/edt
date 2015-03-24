using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Domain {
    public abstract class AgregateRootBase {
        private readonly List<EventBase> _pendingChanges = new List<EventBase>();
        private readonly Dictionary<Type, Action<EventBase>> _handlers = new Dictionary<Type, Action<EventBase>>();

        protected AgregateRootBase()
        {
            RegisterHandlers();
        }

        protected abstract void RegisterHandlers();

        public virtual Guid Id { get; protected set; }
        
        public virtual long Version { get; protected set; }

        protected void Register<TEvent>(Action<TEvent> handler)
            where TEvent : EventBase
        {
            _handlers.Add(typeof(TEvent), evnt => handler((TEvent)evnt));
        }

        protected void Apply<TEvent>(TEvent @event)
            where TEvent : EventBase
        {
            Apply(@event, true);
        }
        
        private void Apply<TEvent>(TEvent @event, bool isNew)
            where TEvent : EventBase
        {
            @event.Version = this.Version + 1;
            _handlers[@event.GetType()](@event);
            this.Version = @event.Version;
            if (isNew)
            {
                _pendingChanges.Add(@event);
            }
        }
    }
}
