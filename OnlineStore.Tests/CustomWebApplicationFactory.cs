using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Web.Data;

public class CustomWebApplicationFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.UseEnvironment("Test");
        builder.ConfigureServices(services =>
        {
            var descriptor = services.SingleOrDefault(
                d => d.ServiceType == typeof(DbContextOptions<OnlineStoreContext>));
            if (descriptor != null)
                services.Remove(descriptor);

            services.AddDbContext<OnlineStoreContext>(options =>
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=OnlineStoreTestDB;Trusted_Connection=True;"));

        });
    }
}
