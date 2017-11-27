# azureappservice-authentication-middleware


Nuget:
https://www.nuget.org/packages/AzureAppserviceAuthenticationMiddleware/

Install-Package AzureAppserviceAuthenticationMiddleware -Pre

usage:

add the following line to the ConfigureServices method in startup.cs

services.AddAuthentication(AzureAppServiceAuthenticationDefaults.AuthenticationScheme).AddAzureAppService();

and then add the following line to the Configure method in startup.cs

app.UseAuthentication();
