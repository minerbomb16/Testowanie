using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using OnlineStore.Web;

namespace OnlineStore.Tests.StepDefinitions
{
    [Binding]
    public class NavigationSteps
    {
        private readonly HttpClient _client;
        private readonly ScenarioContext _ctx;

        public NavigationSteps(ScenarioContext scenarioContext)
        {
            _ctx = scenarioContext;
            var factory = (CustomWebApplicationFactory)_ctx["factory"];
            _client = factory.CreateClient(new Microsoft.AspNetCore.Mvc.Testing.WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = true
            });
        }

        [Given(@"użytkownik otwiera stronę ""(.*)""")]
        public async Task OpenPage(string page)
        {
            var url = GetPageUrl(page);
            var response = await _client.GetAsync(url);
            Assert.IsTrue(response.IsSuccessStatusCode, $"Nie udało się otworzyć strony: {url}");
            _ctx["response"] = response;
        }

        [Then(@"użytkownik powinien zobaczyć stronę ""(.*)""")]
        [Then(@"użytkownik powinien zostać przeniesiony na stronę ""(.*)""")]
        public void ShouldBeOnPage(string expectedPage)
        {
            HttpResponseMessage? response = null;

            if (!_ctx.TryGetValue("response", out var responseObj))
            {
                Assert.Fail("Brak obiektu HttpResponseMessage w ScenarioContext.");
            }
            else if (responseObj is HttpResponseMessage httpResponse)
            {
                response = httpResponse;
            }
            else
            {
                Assert.Fail("Obiekt w ScenarioContext nie jest typu HttpResponseMessage.");
            }

            Assert.IsNotNull(response, "Response jest null.");

            string Normalize(string path) => path.TrimStart('/').ToLowerInvariant();
            var actualPath = Normalize(response!.RequestMessage?.RequestUri?.AbsolutePath ?? string.Empty);

            if (expectedPage.Equals("Home", StringComparison.InvariantCultureIgnoreCase))
            {
                expectedPage = "";
            }

            var expectedPath = Normalize(expectedPage);

            Assert.That(actualPath, Is.EqualTo(expectedPath),
                $"Oczekiwano: {expectedPage}, otrzymano: {actualPath}");
        }

        private string GetPageUrl(string pageName) => pageName.ToLower() switch
        {
            "categories" => "/categories",
            "products" => "/products",
            "orders" => "/orders",
            "home" => "/",
            _ => throw new ArgumentException($"Nieznana strona: {pageName}")
        };
    }
}
