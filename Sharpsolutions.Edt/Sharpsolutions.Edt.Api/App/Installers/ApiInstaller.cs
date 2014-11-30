﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Sharpsolutions.Edt.Api.App.Installers {
    public class ApiInstaller : IWindsorInstaller {
        public void Install(IWindsorContainer container, IConfigurationStore store) {
            container.Register(Classes.FromThisAssembly()
                           .BasedOn<ApiController>()
                           .LifestylePerWebRequest());
        }
    }
}