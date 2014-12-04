using Castle.Windsor;
using Castle.Windsor.Installer;
using Sharpsolutions.Edt.Data.Castle.Installers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle.Windsor {
    public static class ContainerExtensions {
        public static WindsorContainerConfiguration InstallFrom(this IWindsorContainer container) {
            return new WindsorContainerConfiguration(container);
        }

        public static WindsorContainerConfiguration Command(this WindsorContainerConfiguration config) {
            config.Container.Install(FromAssembly.Containing<DataInstaller>());

            return config;
        }
    }
}
