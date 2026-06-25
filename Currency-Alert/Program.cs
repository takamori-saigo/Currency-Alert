
using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();
if (app.Environment.IsProduction())
    app.UseHsts();
app.UseHttpsRedirection();

app.UseForwardedHeaders(new ForwardedHeadersOptions{ForwardedHeaders = ForwardedHeaders.All} );

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();