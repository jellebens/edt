using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Domain.Core {

    [Serializable]
    public class ComponentMissingException : Exception {
        
        public ComponentMissingException(string component) : base(string.Format("Missing component {0}", component)) { }
        public ComponentMissingException(string component, Exception inner) : base(string.Format("Missing component {0}", component), inner) { }
        protected ComponentMissingException(
          global::System.Runtime.Serialization.SerializationInfo info,
          global::System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
