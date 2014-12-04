using Castle.Windsor;
using Castle.Windsor.Installer;
using Sharpsolutions.Edt.Handler.Command.Castle.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle.Windsor {
    public static class ContainerExtensions {
       
        public static WindsorContainerConfiguration Data(this WindsorContainerConfiguration config) {
            config.Container.Install(FromAssembly.Containing<CommandInstaller>());

            return config;
        }
    }
}
