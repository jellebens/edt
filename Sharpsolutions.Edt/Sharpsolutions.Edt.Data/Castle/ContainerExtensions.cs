using Castle.Windsor;
using Castle.Windsor.Installer;
using Sharpsolutions.Edt.Data.Castle.Installers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle.Windsor {
    public static class ContainerExtensions {
        public static WindsorContainerConfiguration Data(this WindsorContainerConfiguration config) {
            Trace.TraceInformation("Installing Data...");
            config.Container.Install(FromAssembly.Containing<DataInstaller>());
            
            return config;
        }
    }
}
