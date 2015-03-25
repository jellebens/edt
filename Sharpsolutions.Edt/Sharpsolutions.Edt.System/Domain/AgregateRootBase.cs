using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Domain {
    public abstract class AgregateRootBase : IEventSourced
    {
        protected readonly List<EventBase> _pendingChanges = new List<EventBase>();
        private readonly Dictionary<Type, Action<EventBase>> _handlers = new Dictionary<Type, Action<EventBase>>();

        protected AgregateRootBase()
        {
            this.Version = 0;
            RegisterHandlers();
        }

        protected abstract void RegisterHandlers();

        public virtual Guid Id { get; protected set; }

        public virtual long Version { get; protected set; }

        public List<EventBase> PendingChanges
        {
            get { return _pendingChanges; }
        }

        protected void Register<TEvent>(Action<TEvent> handler)
            where TEvent : EventBase
        {
            _handlers.Add(typeof (TEvent), evnt => handler((TEvent) evnt));
        }

        protected void Apply<TEvent>(TEvent @event)
            where TEvent : EventBase
        {
            @event.Version = this.Version + 1;
            _handlers[@event.GetType()](@event);
            this.Version = @event.Version;
            _pendingChanges.Add(@event);
        }



        protected void ApplyHistory<TEvent>(TEvent[] events)
            where TEvent : EventBase {
            foreach (TEvent @event in events)
            {
                _handlers[@event.GetType()](@event);
                this.Version = @event.Version;
            }
        }

        void IEventSourced.ClearPendingChanges() {
            PendingChanges.Clear();
        }

        void IEventSourced.Load<TEvent>(IEnumerable<TEvent> events) {
            this.ApplyHistory(events.ToArray());
        }
    }
    

}
