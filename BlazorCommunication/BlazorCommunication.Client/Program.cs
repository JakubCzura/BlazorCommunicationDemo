using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Shared.Constants;

WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp =>
{
    return new HttpClient { BaseAddress = new Uri(ApiGatewayConstants.Address) };
});

await builder.Build().RunAsync();