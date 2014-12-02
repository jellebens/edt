using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Microsoft.Owin.Security.OAuth;
using Sharpsolutions.Edt.Api.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sharpsolutions.Edt.Api.App.Installers {
    public class OAuthInstaller : IWindsorInstaller {
        public void Install(IWindsorContainer container, IConfigurationStore store) {
            container.Register(Component.For<IOAuthAuthorizationServerProvider>()
                .ImplementedBy<EdtAuthorizationServerProvider>()
                .LifeStyle.Transient
              );
        }
    }
}