using Microsoft.AspNetCore.Builder;
using System;

namespace Middleware.Authentication.AppService
{
    public static class AzureAppServiceAuthenticationAppBuilderExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        [Obsolete("UseAzureAppServiceAuthentication is obsolete. Configure AzureAppService authentication with AddAuthentication().AddAzureAppService in ConfigureServices. See https://go.microsoft.com/fwlink/?linkid=845470 for more details.", error: true)]
        public static IApplicationBuilder UseAzureAppServiceAuthentication(this IApplicationBuilder app)
        {
            throw new NotSupportedException("This method is no longer supported, see https://go.microsoft.com/fwlink/?linkid=845470");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        [Obsolete("UseAzureAppServiceAuthentication is obsolete. Configure AzureAppService authentication with AddAuthentication().AddAzureAppService in ConfigureServices. See https://go.microsoft.com/fwlink/?linkid=845470 for more details.", error: true)]
        public static IApplicationBuilder UseAzureAppServiceAuthentication(this IApplicationBuilder app, AzureAppServiceAuthenticationOptions options)
        {
            throw new NotSupportedException("This method is no longer supported, see https://go.microsoft.com/fwlink/?linkid=845470");
        }
    }
}
