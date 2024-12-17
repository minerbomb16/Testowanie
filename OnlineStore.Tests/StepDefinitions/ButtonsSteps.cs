using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using OnlineStore.Web;
using OnlineStore.Tests.Infrastructure;

namespace OnlineStore.Tests.StepDefinitions
{
    [Binding]
    public class ButtonsSteps
    {
        private readonly HttpClient _client;
        private HttpResponseMessage _response;
        private readonly TestDatabase _database;

        public ButtonsSteps()
        {
            _database = new TestDatabase();
            var factory = new WebApplicationFactory<Program>();
            _client = factory.CreateClient();
        }

        [Given(@"baza danych zawiera 3 kategorie, 3 produkty i 3 zamówienia")]
        public void GivenBazaDanychZawieraTrzyKategorieIProdukty()
        {
            Assert.IsNotNull(_database.Context, "Baza danych nie została poprawnie utworzona.");
        }

        // Kroki dla kategorii
        [When(@"użytkownik klika przycisk ""(.*)"" dla pierwszej kategorii")]
        public async Task WhenUzytkownikKlikniePrzyciskDlaPierwszejKategorii(string button)
        {
            var action = button.ToLower() switch
            {
                "edit" => "/categories/edit/1",
                "details" => "/categories/details/1",
                "delete" => "/categories/delete/1",
                _ => throw new ArgumentException($"Nieznany przycisk: {button}")
            };

            _response = await _client.GetAsync(action);
        }

        // Kroki dla produktów
        [When(@"użytkownik klika przycisk ""(.*)"" dla pierwszego produktu")]
        public async Task WhenUzytkownikKlikniePrzyciskDlaPierwszegoProduktu(string button)
        {
            var action = button.ToLower() switch
            {
                "edit" => "/products/edit/1",
                "details" => "/products/details/1",
                "delete" => "/products/delete/1",
                _ => throw new ArgumentException($"Nieznany przycisk: {button}")
            };

            _response = await _client.GetAsync(action);
        }

        // Kroki dla zamówień
        [When(@"użytkownik klika przycisk ""(.*)"" dla pierwszego zamówienia")]
        public async Task WhenUzytkownikKlikniePrzyciskDlaPierwszegoZamowienia(string button)
        {
            var action = button.ToLower() switch
            {
                "edit" => "/orders/edit/1",
                "details" => "/orders/details/1",
                "delete" => "/orders/delete/1",
                _ => throw new ArgumentException($"Nieznany przycisk: {button}")
            };

            _response = await _client.GetAsync(action);
        }

        [Then(@"użytkownik powinien zostać przeniesiony na stronę ""(.*)""")]
        public void ThenUzytkownikPowinienZostacPrzeniesionyNaStrone(string expectedUrl)
        {
            Assert.IsTrue(_response.RequestMessage.RequestUri.AbsolutePath.Equals(expectedUrl),
                $"Oczekiwano: {expectedUrl}, ale otrzymano: {_response.RequestMessage.RequestUri.AbsolutePath}");
        }
    }
}
