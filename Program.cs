using Microsoft.EntityFrameworkCore;  
using BookShop.DataAccess.Context;  
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Category}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/debug/routes", async context =>
    {
        await context.Response.WriteAsync("Registered routes:\n");
        foreach (var endpoint in endpoints.DataSources
            .SelectMany(ds => ds.Endpoints))
        {
            await context.Response.WriteAsync($"{endpoint.DisplayName}\n");
        }
    });
});

app.Run();
