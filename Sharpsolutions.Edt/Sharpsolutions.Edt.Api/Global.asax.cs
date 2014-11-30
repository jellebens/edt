using Castle.Windsor;
using Sharpsolutions.Edt.System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Routing;

namespace Sharpsolutions.Edt.Api {
    public class WebApiApplication : HttpApplication {
        private readonly IWindsorContainer _Container;

        public WebApiApplication() {
            _Container = new WindsorContainer();
        }

        protected void Application_Start() {
            GlobalConfiguration.Configuration.Services.Replace(
            typeof(IHttpControllerActivator),
                    new WindsorControllerActivator(this._Container));
            
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        public override void Dispose() {
            _Container.Dispose();
            base.Dispose();
        }
    }
}
