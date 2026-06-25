
using System.Reflection.Metadata;
using Currency_Alert.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;

var builder = WebApplication.CreateBuilder(args);

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(),"/nlog.config"));

builder.Services.ConfigureLoggerManager();
builder.Services.ConfigureCors();
builder.Services.ConfigureSqlConnection(builder.Configuration);
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.ConfigureControllers();

var app = builder.Build();
if (app.Environment.IsProduction())
    app.UseHsts();
app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseForwardedHeaders(new ForwardedHeadersOptions{ForwardedHeaders = ForwardedHeaders.All} );

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();