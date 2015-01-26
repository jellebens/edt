using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Sharpsolutions.Edt.Api.Security;
using Microsoft.Owin.Cors;
using Castle.Windsor;

//Install-Package Microsoft.Owin.Host.SystemWeb 
[assembly: OwinStartup(typeof(Sharpsolutions.Edt.Api.Startup))]

namespace Sharpsolutions.Edt.Api {
    public class Startup {
        public void Configuration(IAppBuilder app) {
            IWindsorContainer _Container = new WindsorContainer();
            WindsorConfig.Register(_Container);

            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config, _Container);
            OAuthConfig.Register(app, _Container);
            //Install-Package Microsoft.Owin.Cors
            app.UseCors(CorsOptions.AllowAll);
            //Install-Package Microsoft.AspNet.WebApi.Owin
            app.UseWebApi(config);
        }
    }
}
