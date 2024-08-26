string userInterfaceOriginPolicy = "user-interface";

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: userInterfaceOriginPolicy,
                      policy =>
                      {
                          policy.WithOrigins(builder.Configuration.GetValue<string>("UserInterface:Address")!)
                                .AllowAnyOrigin();
                      });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(userInterfaceOriginPolicy);

app.UseAuthorization();

app.MapControllers();

app.Run();
