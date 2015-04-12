using System.Diagnostics;
using Castle.Windsor.Installer;
using Sharpsolutions.Edt.Data.Castle.Installers;

namespace Castle.Windsor {
    public static class ContainerExtensions {
        public static WindsorContainerConfiguration Data(this WindsorContainerConfiguration config) {
            Trace.TraceInformation("Installing Data...");
            config.Container.Install(FromAssembly.Containing<DataInstaller>());
            
            return config;
        }
    }
}
