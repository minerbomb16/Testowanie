using System;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Models;
using OnlineStore.Web.Data;

namespace OnlineStore.Tests.Infrastructure
{
    public class TestDatabase : IDisposable
    {
        private const string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=OnlineStoreTestDB;Trusted_Connection=True;";

        public OnlineStoreContext Context { get; private set; }

        public TestDatabase()
        {
            var options = new DbContextOptionsBuilder<OnlineStoreContext>()
                .UseSqlServer(ConnectionString)
                .Options;

            Context = new OnlineStoreContext(options);
        }

        public void Reset()
        {
            Context.Database.EnsureDeleted();
            Context.Database.EnsureCreated();
            SeedDatabase();
        }

        private void SeedDatabase()
        {
            var categories = new[]
            {
                new Category { Name = "Category 1" },
                new Category { Name = "Category 2" },
                new Category { Name = "Category 3" }
};
            Context.Categories.AddRange(categories);
            Context.SaveChanges();

            var products = new[]
            {
                new Product { Name = "Product 1", Price = 10.0m, CategoryId = 1 },
                new Product { Name = "Product 2", Price = 20.0m, CategoryId = 2 },
                new Product { Name = "Product 3", Price = 30.0m, CategoryId = 3 }
};
            Context.Products.AddRange(products);
            Context.SaveChanges();

            var orders = new[]
            {
                new Order { CustomerName = "Customer 1", OrderDate = DateTime.UtcNow },
                new Order { CustomerName = "Customer 2", OrderDate = DateTime.UtcNow },
                new Order { CustomerName = "Customer 3", OrderDate = DateTime.UtcNow }
};
            Context.Orders.AddRange(orders);
            Context.SaveChanges();

            var orderProducts = new[]
            {
                new OrderProduct { OrderId = 1, ProductId = 1, Quantity = 2 },
                new OrderProduct { OrderId = 1, ProductId = 2, Quantity = 1 },
                new OrderProduct { OrderId = 2, ProductId = 2, Quantity = 3 },
                new OrderProduct { OrderId = 3, ProductId = 3, Quantity = 5 }
            };
            Context.OrderProducts.AddRange(orderProducts);
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
