using Castle.Windsor;
using Castle.Windsor.Installer;
using Sharpsolutions.Edt.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle.Windsor {
    public static class ContainerExtensions {
        public static WindsorContainerConfiguration System(this WindsorContainerConfiguration config) {
            config.Container.Install(FromAssembly.Containing<Settings>());

            return config;
        }
    }
}
