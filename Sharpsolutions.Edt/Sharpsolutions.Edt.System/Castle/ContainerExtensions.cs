using Castle.Windsor;
using Castle.Windsor.Installer;
using Sharpsolutions.Edt.System;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle.Windsor {
    public static class ContainerExtensions {
        public static WindsorContainerConfiguration InstallFrom(this IWindsorContainer container) {
            return new WindsorContainerConfiguration(container);
        }

        public static WindsorContainerConfiguration System(this WindsorContainerConfiguration config) {
            Trace.TraceInformation("Installing System...");

            config.Container.Install(FromAssembly.Containing<Settings>());

            return config;
        }
    }
}
