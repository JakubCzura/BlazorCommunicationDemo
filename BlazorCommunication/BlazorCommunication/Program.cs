using BlazorCommunication.Components;
using Shared.Constants;
using BlazorCommunication.Shared.Application.ExtensionMethods;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationDI();

// Add services to the container.
builder.Services.AddScoped(sp =>
{
    return new HttpClient { BaseAddress = new Uri(ApiGatewayConstants.Address) };
});

builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents()
                .AddInteractiveWebAssemblyComponents();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode()
   .AddInteractiveWebAssemblyRenderMode()
   .AddAdditionalAssemblies(typeof(BlazorCommunication.Client._Imports).Assembly);

app.Run();