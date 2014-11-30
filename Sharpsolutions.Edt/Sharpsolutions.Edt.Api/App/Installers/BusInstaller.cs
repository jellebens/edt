using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Sharpsolutions.Edt.Api.App.Client;
using Sharpsolutions.Edt.System.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sharpsolutions.Edt.Api.App.Installers {
    public class BusInstaller : IWindsorInstaller {
        public void Install(IWindsorContainer container, IConfigurationStore store) {
            container.Register(
              Classes.FromAssemblyContaining<Bus>()
                  .BasedOn<IBus>()
                  .WithService.FirstInterface()
                  .LifestylePerWebRequest()
              );
        }
    }
}