using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Services;
using Services.Interfaces;
using UI;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<IAccountServices, AccountServices>(x =>
{
    x.BaseAddress = new Uri("https://localhost:7086/");
    x.DefaultRequestHeaders.Add("Accept", "application/+json");
});


await builder.Build().RunAsync();
