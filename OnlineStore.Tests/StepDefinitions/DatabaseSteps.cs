using TechTalk.SpecFlow;
using NUnit.Framework;
using Microsoft.Extensions.DependencyInjection;
using OnlineStore.Web.Data;
using System.Linq;

namespace OnlineStore.Tests.StepDefinitions
{
    [Binding]
    public class DatabaseSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public DatabaseSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"baza danych zawiera 3 kategorie, 3 produkty i 3 zamówienia")]
        public void GivenDatabaseHasInitialData()
        {
            var factory = (CustomWebApplicationFactory)_scenarioContext["factory"];
            var context = factory.Services.GetRequiredService<OnlineStoreContext>();

            Assert.IsNotNull(context, "Kontekst bazy danych jest null.");
            Assert.AreEqual(3, context.Categories.Count(), "Nie ma 3 kategorii w bazie.");
            Assert.AreEqual(3, context.Products.Count(), "Nie ma 3 produktów w bazie.");
            Assert.AreEqual(3, context.Orders.Count(), "Nie ma 3 zamówień w bazie.");
        }

        [Given(@"w bazie danych nie ma kategorii ""(.*)""")]
        public void GivenDatabaseHasNoCategory(string categoryName)
        {
            var factory = (CustomWebApplicationFactory)_scenarioContext["factory"];
            var context = factory.Services.GetRequiredService<OnlineStoreContext>();

            var exists = context.Categories.Any(c => c.Name == categoryName);
            Assert.IsFalse(exists, $"Kategoria {categoryName} istnieje, a nie powinna.");
        }

        [Then(@"w bazie danych powinna być kategoria ""(.*)""")]
        public void ThenDatabaseShouldHaveCategory(string categoryName)
        {
            var factory = (CustomWebApplicationFactory)_scenarioContext["factory"];
            var context = factory.Services.GetRequiredService<OnlineStoreContext>();

            var exists = context.Categories.Any(c => c.Name == categoryName);
            Assert.IsTrue(exists, $"Kategoria {categoryName} nie została znaleziona w bazie danych.");
        }

        [Given(@"w bazie danych nie ma produktu ""(.*)""")]
        public void GivenDatabaseHasNoProduct(string productName)
        {
            var factory = (CustomWebApplicationFactory)_scenarioContext["factory"];
            var context = factory.Services.GetRequiredService<OnlineStoreContext>();

            var exists = context.Products.Any(c => c.Name == productName);
            Assert.IsFalse(exists, $"Produkt {productName} istnieje, a nie powinien.");
        }

        [Then(@"w bazie danych powinien być produkt ""(.*)""")]
        public void ThenDatabaseShouldHaveProduct(string productName)
        {
            var factory = (CustomWebApplicationFactory)_scenarioContext["factory"];
            var context = factory.Services.GetRequiredService<OnlineStoreContext>();

            var exists = context.Products.Any(c => c.Name == productName);
            Assert.IsTrue(exists, $"Produkt {productName} nie został znaleziony w bazie danych.");
        }
    }
}
