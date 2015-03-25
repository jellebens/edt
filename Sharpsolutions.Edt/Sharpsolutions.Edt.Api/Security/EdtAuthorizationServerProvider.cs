using Castle.Core.Logging;
using Microsoft.Owin.Security.OAuth;
using Sharpsolutions.Edt.Domain.Account;
using Sharpsolutions.Edt.System.Data;
using Sharpsolutions.Edt.System.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Sharpsolutions.Edt.Data.Azure;

namespace Sharpsolutions.Edt.Api.Security {
    //Install-Package Microsoft.Owin.Security.OAuth
    public class EdtAuthorizationServerProvider : OAuthAuthorizationServerProvider {
        private readonly IUserRepository _UserRepository;
        private readonly ILogger _Logger;
        public EdtAuthorizationServerProvider(IUserRepository userRepository, ILoggerFactory loggerfactory) {
            _UserRepository = userRepository;
            _Logger = loggerfactory.Create(Loggers.Security.Authentication);
        }

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context) {
            await Task.Run(() => context.Validated());
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context) {
            await Task.Run(() => {
                context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

                _Logger.InfoFormat("Trying to authenticate: {0}", context.UserName);

                User u = _UserRepository.Get(context.UserName);

                if (u == null || !u.TryLogin(context.Password)) {
                    _Logger.InfoFormat("Failed to authenticate: {0}. User {1}. Password verification {2}", context.UserName, u == null ? "not found" : "found", (u != null && u.TryLogin(context.Password)) ? "succeeded" : "failed");
                    context.SetError("invalid_grant", "The user name or password is incorrect.");
                    return;
                }

                _Logger.InfoFormat("Access for user: {0} granted", context.UserName);

                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));

                context.Validated(identity);
                
                _UserRepository.CommitChanges(u);
            });
        }
    }
}