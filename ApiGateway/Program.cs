string userInterfaceOriginPolicy = "user-interface";

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: userInterfaceOriginPolicy,
                      policy =>
                      {
                          policy.WithOrigins(builder.Configuration.GetValue<string>("UserInterface:Address")!)
                                .AllowAnyOrigin();
                      });
});

builder.Services.AddReverseProxy()
                .LoadFromConfig(builder.Configuration.GetSection("ApiGateway"));

WebApplication app = builder.Build();

app.UseHttpsRedirection();

app.UseCors(userInterfaceOriginPolicy);

app.UseAuthorization();

app.MapReverseProxy();

app.Run();
