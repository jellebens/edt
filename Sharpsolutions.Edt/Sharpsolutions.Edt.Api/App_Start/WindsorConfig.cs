using Castle.Windsor;
using Castle.Windsor.Installer;
using Sharpsolutions.Edt.System;
using Sharpsolutions.Edt.System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sharpsolutions.Edt.Data.Castle.Installers;

namespace Sharpsolutions.Edt.Api {
    public class WindsorConfig {
        public static void Register(IWindsorContainer container) {
            container.Install(FromAssembly.This());
            container.Install(FromAssembly.Containing<Settings>());
            //install data access
            container.Install(FromAssembly.Containing<DataInstaller>());
        }
    }
}