using TechTalk.SpecFlow;
using Microsoft.Extensions.DependencyInjection;
using OnlineStore.Web.Data;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

[Binding]
public class Hooks
{
    private readonly ScenarioContext _scenarioContext;
    private CustomWebApplicationFactory _factory;

    public Hooks(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [BeforeScenario]
    public void BeforeScenario()
    {
        // Tworzymy fabrykę aplikacji testowej
        _factory = new CustomWebApplicationFactory();

        // Zapamiętujemy w ScenarioContext
        _scenarioContext["factory"] = _factory;

        // Pobieramy kontekst z fabryki
        var context = _factory.Services.GetRequiredService<OnlineStoreContext>();

        // Resetujemy bazę danych
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        // Seedujemy dane tak jak poprzednio
        SeedDatabase(context);
    }

    [AfterScenario]
    public void AfterScenario()
    {
        // Po zakończeniu scenariusza czyścimy bazę danych
        var factory = (CustomWebApplicationFactory)_scenarioContext["factory"];
        var context = factory.Services.GetRequiredService<OnlineStoreContext>();

        context.Database.EnsureDeleted();
    }

    private void SeedDatabase(OnlineStoreContext context)
    {
        var categories = new[]
        {
            new OnlineStore.Domain.Models.Category { Name = "Category 1" },
            new OnlineStore.Domain.Models.Category { Name = "Category 2" },
            new OnlineStore.Domain.Models.Category { Name = "Category 3" }
        };
        context.Categories.AddRange(categories);
        context.SaveChanges();

        var products = new[]
        {
            new OnlineStore.Domain.Models.Product { Name = "Product 1", Price = 10.0m, CategoryId = 1 },
            new OnlineStore.Domain.Models.Product { Name = "Product 2", Price = 20.0m, CategoryId = 2 },
            new OnlineStore.Domain.Models.Product { Name = "Product 3", Price = 30.0m, CategoryId = 3 }
        };
        context.Products.AddRange(products);
        context.SaveChanges();

        var orders = new[]
        {
            new OnlineStore.Domain.Models.Order { CustomerName = "Customer 1", OrderDate = DateTime.UtcNow },
            new OnlineStore.Domain.Models.Order { CustomerName = "Customer 2", OrderDate = DateTime.UtcNow },
            new OnlineStore.Domain.Models.Order { CustomerName = "Customer 3", OrderDate = DateTime.UtcNow }
        };
        context.Orders.AddRange(orders);
        context.SaveChanges();

        var orderProducts = new[]
        {
            new OnlineStore.Domain.Models.OrderProduct { OrderId = 1, ProductId = 1, Quantity = 2 },
            new OnlineStore.Domain.Models.OrderProduct { OrderId = 1, ProductId = 2, Quantity = 1 },
            new OnlineStore.Domain.Models.OrderProduct { OrderId = 2, ProductId = 2, Quantity = 3 },
            new OnlineStore.Domain.Models.OrderProduct { OrderId = 3, ProductId = 3, Quantity = 5 }
        };
        context.OrderProducts.AddRange(orderProducts);
        context.SaveChanges();
    }
}
