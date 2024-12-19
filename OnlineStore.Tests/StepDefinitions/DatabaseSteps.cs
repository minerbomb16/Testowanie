using TechTalk.SpecFlow;
using NUnit.Framework;
using OnlineStore.Tests.Infrastructure;
using System.Linq;

namespace OnlineStore.Tests.StepDefinitions
{
    [Binding]
    public class DatabaseSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private TestDatabase TestDatabase => (TestDatabase)_scenarioContext["testDatabase"];

        public DatabaseSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"baza danych zawiera 3 kategorie, 3 produkty i 3 zamówienia")]
        public void GivenDatabaseHasInitialData()
        {
            Assert.IsNotNull(TestDatabase.Context, "Baza danych nie została poprawnie utworzona.");
            Assert.AreEqual(3, TestDatabase.Context.Categories.Count());
            Assert.AreEqual(3, TestDatabase.Context.Products.Count());
            Assert.AreEqual(3, TestDatabase.Context.Orders.Count());
        }

        [Given(@"w bazie danych nie ma kategorii ""(.*)""")]
        public void GivenDatabaseHasNoCategory(string categoryName)
        {
            var exists = TestDatabase.Context.Categories.Any(c => c.Name == categoryName);
            Assert.IsFalse(exists, $"Kategoria {categoryName} istnieje, a nie powinna.");
        }

        [Then(@"w bazie danych powinna być kategoria ""(.*)""")]
        public void ThenDatabaseShouldHaveCategory(string categoryName)
        {
            var exists = TestDatabase.Context.Categories.Any(c => c.Name == categoryName);
            Assert.IsTrue(exists, $"Kategoria {categoryName} nie została znaleziona w bazie danych.");
        }
    }
}
