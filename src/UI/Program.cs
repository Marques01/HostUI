using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Services;
using Services.Authentication;
using Services.Authentication.Interfaces;
using Services.Interfaces;
using System.Net.Http.Headers;
using UI;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<TokenAuthenticationProvider>();

builder.Services.AddScoped<IAuthorizeServices, TokenAuthenticationProvider>(
    provider => provider.GetRequiredService<TokenAuthenticationProvider>()
    );

builder.Services.AddScoped<AuthenticationStateProvider, TokenAuthenticationProvider>(
  provider => provider.GetRequiredService<TokenAuthenticationProvider>());

builder.Services.AddHttpClient<IAccountServices, AccountServices>(x =>
{
    x.BaseAddress = new Uri("https://localhost:7086/");
    x.DefaultRequestHeaders.Add("Accept", "application/+json");    
});

builder.Services.AddHttpClient<ICapacityServices, CapacityServices>(x =>
{
    x.BaseAddress = new Uri("https://localhost:7086/");
    x.DefaultRequestHeaders.Add("Accept", "application/+json");    
});

builder.Services.AddOptions();

builder.Services.AddAuthorizationCore();

await builder.Build().RunAsync();
