using Microsoft.AspNetCore.Authentication;
using System;

namespace Middleware.Authentication.AppService
{
    public static class AzureAppServiceAuthenticationExtensions
    {
        public static AuthenticationBuilder AddAzureAppService(this AuthenticationBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            return builder.AddAzureAppService(AzureAppServiceAuthenticationDefaults.AuthenticationScheme);
        }

        public static AuthenticationBuilder AddAzureAppService(this AuthenticationBuilder builder, string authenticationScheme)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }
            if (string.IsNullOrEmpty(authenticationScheme))
            {
                throw new ArgumentNullException(nameof(authenticationScheme));
            }

            return builder.AddScheme<AzureAppServiceAuthenticationOptions, AzureAppServiceAuthenticationHandler>(authenticationScheme, _ => { });
        }
    }
}
