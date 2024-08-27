using BlazorCommunication.Shared.Application.ExtensionMethods;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Shared.Constants;

WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddApplicationDI();

builder.Services.AddScoped(sp =>
{
    return new HttpClient { BaseAddress = new Uri(ApiGatewayConstants.Address) };
});

await builder.Build().RunAsync();