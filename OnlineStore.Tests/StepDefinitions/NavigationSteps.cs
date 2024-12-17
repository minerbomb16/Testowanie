using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using OnlineStore.Web;

namespace OnlineStore.Tests.StepDefinitions
{
    [Binding]
    public class NavigationSteps
    {
        private readonly HttpClient _client;
        private HttpResponseMessage _response;

        public NavigationSteps()
        {
            // Konfiguracja WebApplicationFactory dla testów
            var factory = new WebApplicationFactory<Program>();
            _client = factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = true // Zezwalanie na przekierowania
            });
        }

        [Given(@"użytkownik otwiera stronę ""(.*)""")]
        public async Task GivenUzytkownikOtwieraStrone(string page)
        {
            var url = page.ToLower() switch
            {
                "categories" => "/categories",
                "products" => "/products",
                "orders" => "/orders",
                "home" => "/",
                _ => throw new ArgumentException("Nieznana strona: " + page)
            };

            _response = await _client.GetAsync(url);
            Assert.IsTrue(_response.IsSuccessStatusCode, $"Nie udało się otworzyć strony: {url}");
        }

        [When(@"użytkownik klika przycisk ""(.*)""")]
        public async Task WhenUzytkownikKlikaPrzycisk(string button)
        {
            var url = button.ToLower() switch
            {
                "home" => "/",
                _ => throw new ArgumentException("Nieznany przycisk: " + button)
            };

            _response = await _client.GetAsync(url);
        }

        [Then(@"użytkownik powinien zobaczyć stronę ""(.*)""")]
        public void ThenUzytkownikPowinienZobaczycStrone(string expectedPage)
        {
            var expectedUrl = expectedPage.ToLower() switch
            {
                "categories" => "/categories",
                "products" => "/products",
                "orders" => "/orders",
                "home" => "/",
                _ => throw new ArgumentException("Nieznana strona: " + expectedPage)
            };

            Assert.IsTrue(_response.RequestMessage.RequestUri.AbsolutePath.Equals(expectedUrl),
                $"Oczekiwano: {expectedUrl}, ale otrzymano: {_response.RequestMessage.RequestUri.AbsolutePath}");
        }
    }
}
