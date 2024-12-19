using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Web;
using OnlineStore.Web.Data;

public class CustomWebApplicationFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.UseEnvironment("Test");
        builder.ConfigureServices(services =>
        {
            // Znajdź aktualną rejestrację OnlineStoreContext
            var descriptor = services.SingleOrDefault(
                d => d.ServiceType == typeof(DbContextOptions<OnlineStoreContext>));
            if (descriptor != null)
                services.Remove(descriptor);

            services.AddDbContext<OnlineStoreContext>(options =>
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=OnlineStoreTestDB;Trusted_Connection=True;"));

            // Usuń filtr ValidateAntiForgeryToken z pipeline'u MVC tylko na potrzeby testów
            services.PostConfigure<MvcOptions>(options =>
            {
                for (int i = options.Filters.Count - 1; i >= 0; i--)
                {
                    if (options.Filters[i].GetType().Name == "ValidateAntiForgeryTokenAttribute")
                    {
                        options.Filters.RemoveAt(i);
                    }
                }
            });
        });
    }
}
