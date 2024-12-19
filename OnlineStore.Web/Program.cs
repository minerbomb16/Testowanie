using Microsoft.EntityFrameworkCore;
using OnlineStore.Web.Data;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using OnlineStore.Web.Binders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Insert the custom decimal model binder provider.
builder.Services.AddControllersWithViews(options =>
{
    options.ModelBinderProviders.Insert(0, new CustomDecimalModelBinderProvider());
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowMobileApp",
        builder =>
        {
            builder.WithOrigins("http://localhost", "https://10.0.2.2", "http://10.0.2.2")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});



if (builder.Environment.IsEnvironment("Test"))
{
    builder.Services.AddDbContext<OnlineStoreContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("OnlineStoreTestDB")));
}
else
{
    builder.Services.AddDbContext<OnlineStoreContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("OnlineStoreDB")));
}


// Add logging configuration.
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var app = builder.Build();

app.UseCors("AllowMobileApp");

// Set up the supported cultures.
var defaultCulture = new CultureInfo("pl-PL");
var supportedCultures = new[] { defaultCulture };

// Configure the localization middleware.
app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture(defaultCulture),
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Detailed error pages in development.
}
else
{
    app.UseExceptionHandler("/Home/Error"); // Generic error handler.
    app.UseHsts(); // Enforce HTTPS in production.
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization(); // Ensure proper authorization handling.

// Map default routes.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Add global error logging for unhandled exceptions.
app.Use(async (context, next) =>
{
    try
    {
        await next();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Unhandled exception: {ex.Message}");
        throw;
    }
});

app.Run();

public partial class Program { }