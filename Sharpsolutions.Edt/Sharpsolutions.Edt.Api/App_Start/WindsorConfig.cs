using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sharpsolutions.Edt.Api {
    public class WindsorConfig {
        public static void Register(IWindsorContainer container) {
            container.Install(FromAssembly.This());




        }
    }
}