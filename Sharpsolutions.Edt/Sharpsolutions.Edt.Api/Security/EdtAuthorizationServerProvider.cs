using Microsoft.Owin.Security.OAuth;
using Sharpsolutions.Edt.Domain.Account;
using Sharpsolutions.Edt.System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace Sharpsolutions.Edt.Api.Security {
    public class EdtAuthorizationServerProvider : OAuthAuthorizationServerProvider {
        private IRepository<User, string> _UserRepository;

        public EdtAuthorizationServerProvider(IRepository<User, string> userRepository) {
            _UserRepository = userRepository;
        }

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context) {
            await Task.Run(() => context.Validated());
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context) {
            await Task.Run(() => {
                context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

                User u = _UserRepository.Get(context.UserName);

                if (u == null || !u.Verify(context.Password)) {
                    context.SetError("invalid_grant", "The user name or password is incorrect.");
                    return;
                }
                
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));

                context.Validated(identity);
            });
        }
    }
}