using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using CleanBlazor.WebUI.Client;
using CleanBlazor.WebUI.Client.Authorization;
using CleanBlazor.WebUI.Shared.Authorization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("CleanBlazor.WebUI.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("CleanBlazor.WebUI.ServerAPI"));

builder.Services
    .AddApiAuthorization()
    .AddAccountClaimsPrincipalFactory<CustomAccountClaimsPrincipalFactory>();

builder.Services.AddSingleton<IAuthorizationHandler, PermissionAuthorizationHandler>();
builder.Services.AddSingleton<IAuthorizationPolicyProvider, FlexibleAuthorizationPolicyProvider>();

builder.Services.AddSingleton(services => (IJSInProcessRuntime)services.GetRequiredService<IJSRuntime>());

builder.Services.Scan(scan => scan
    .FromAssemblyOf<IWeatherForecastClient>()
    .AddClasses()
    .AsImplementedInterfaces()
    .WithScopedLifetime());

await builder.Build().RunAsync();
