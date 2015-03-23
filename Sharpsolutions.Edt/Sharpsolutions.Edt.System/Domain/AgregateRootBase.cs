using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Domain {
    public abstract class AgregateRootBase {
        private readonly List<EventBase> _changes = new List<EventBase>();

        public virtual Guid Id { get; protected set; }
        
        public virtual long Version { get; protected set; }

        protected void Register(EventBase eEventBase)
        {
            Register(eEventBase, true);
        }

        private void Register(EventBase eEventBase, bool isNew)
        {
            this.AsDynamic().Apply(eEventBase);

            if (isNew)
            {
                _changes.Add(eEventBase);
            }
        }
    }
}
