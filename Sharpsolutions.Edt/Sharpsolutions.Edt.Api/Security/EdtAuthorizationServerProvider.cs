﻿using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace Sharpsolutions.Edt.Api.Security {
    public class EdtAuthorizationServerProvider : OAuthAuthorizationServerProvider {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context) {
            await Task.Run(() => context.Validated());
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context) {
            await Task.Run(() => {
                context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });


                if (!(context.UserName == "admin" && context.Password == "admin2711")) {
                    context.SetError("invalid_grant", "The user name or password is incorrect.");
                    return;
                }


                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim("sub", context.UserName));
                identity.AddClaim(new Claim("role", "user"));

                context.Validated(identity);
            });
        }
    }
}