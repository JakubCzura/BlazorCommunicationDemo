using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp =>

    new HttpClient { BaseAddress = new Uri(builder.Configuration.GetValue<string>("Api:WeatherApi:Address")!) }
);

await builder.Build().RunAsync();