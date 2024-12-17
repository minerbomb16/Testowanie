using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Web.Data;
using OnlineStore.Domain.Models;

namespace OnlineStore.Tests.Infrastructure
{
    public class TestDatabase : IDisposable
    {
        public OnlineStoreContext Context { get; private set; }
        private readonly SqliteConnection _connection;

        public TestDatabase()
        {
            // Tworzenie bazy SQLite w pamięci
            _connection = new SqliteConnection("Filename=:memory:");
            _connection.Open();

            var options = new DbContextOptionsBuilder<OnlineStoreContext>()
                .UseSqlite(_connection)
                .Options;

            Context = new OnlineStoreContext(options);
            Context.Database.EnsureDeleted();
            Context.Database.EnsureCreated();
            SeedDatabase();
        }

        private void SeedDatabase()
        {
            // Tworzenie przykładowych kategorii
            var categories = new[]
            {
                new Category { CategoryId = 1, Name = "Category 1" },
                new Category { CategoryId = 2, Name = "Category 2" },
                new Category { CategoryId = 3, Name = "Category 3" }
            };

            Context.Categories.AddRange(categories);
            Context.SaveChanges();

            // Tworzenie produktów powiązanych z kategoriami
            var products = new[]
            {
                new Product { ProductId = 1, Name = "Product 1", Price = 10.0m, CategoryId = 1 },
                new Product { ProductId = 2, Name = "Product 2", Price = 20.0m, CategoryId = 2 },
                new Product { ProductId = 3, Name = "Product 3", Price = 30.0m, CategoryId = 3 }
            };

            Context.Products.AddRange(products);
            Context.SaveChanges();

            // Tworzenie zamówień
            var orders = new[]
            {
                new Order { OrderId = 1, CustomerName = "Customer 1", OrderDate = DateTime.UtcNow },
                new Order { OrderId = 2, CustomerName = "Customer 2", OrderDate = DateTime.UtcNow },
                new Order { OrderId = 3, CustomerName = "Customer 3", OrderDate = DateTime.UtcNow }
            };

            Context.Orders.AddRange(orders);
            Context.SaveChanges();

            // Dodanie relacji między zamówieniami a produktami (OrderProduct)
            var orderProducts = new[]
            {
                new OrderProduct { OrderId = 1, ProductId = 1, Quantity = 2 },
                new OrderProduct { OrderId = 1, ProductId = 2, Quantity = 1 },
                new OrderProduct { OrderId = 2, ProductId = 2, Quantity = 3 },
                new OrderProduct { OrderId = 3, ProductId = 3, Quantity = 5 }
            };

            Context.Set<OrderProduct>().AddRange(orderProducts);
            Context.SaveChanges();
        }

        public void Dispose()
        {
            // Zamknięcie kontekstu i połączenia SQLite
            Context.Dispose();
            _connection.Dispose();
        }
    }
}
