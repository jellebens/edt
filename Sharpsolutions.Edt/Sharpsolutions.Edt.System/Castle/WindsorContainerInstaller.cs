using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle.Windsor {
    public class WindsorContainerConfiguration {
        public IWindsorContainer Container { get; private set; }

        public WindsorContainerConfiguration(IWindsorContainer container) {
            this.Container = container;
        }
    }


}
