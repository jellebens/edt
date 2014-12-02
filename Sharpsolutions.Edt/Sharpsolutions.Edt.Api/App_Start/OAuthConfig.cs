using Castle.Windsor;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using Sharpsolutions.Edt.Api.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sharpsolutions.Edt.Api {
    public static class OAuthConfig {
        internal static void Register(IAppBuilder app, IWindsorContainer _Container) {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions() {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = _Container.Resolve<IOAuthAuthorizationServerProvider>()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}
