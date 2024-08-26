using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp =>
{
    return new HttpClient { BaseAddress = new Uri("https://localhost:7250") };
});

await builder.Build().RunAsync();