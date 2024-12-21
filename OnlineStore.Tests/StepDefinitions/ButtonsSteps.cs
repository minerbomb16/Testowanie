using TechTalk.SpecFlow;

namespace OnlineStore.Tests.StepDefinitions
{
    [Binding]
    public class ButtonsSteps
    {
        private readonly HttpClient _client;
        private readonly ScenarioContext _ctx;
        public static string postResponse = "";

        public ButtonsSteps(ScenarioContext scenarioContext)
        {
            _ctx = scenarioContext;
            var factory = (CustomWebApplicationFactory)_ctx["factory"];
            _client = factory.CreateClient();
        }

        [When(@"użytkownik klika przycisk ""(.*)"" dla pierwszego elementu")]
        public async Task WhenUserClicksButtonForFirstElement(string button)
        {
            var page = NavigationSteps.page2;
            var buttonName = char.ToUpper(page[0]) + page.Substring(1);
            var action = GetUrl(buttonName, button);
            await SendRequestAndStoreResponse(action, HttpMethod.Get);
        }

        [When(@"użytkownik klika przycisk ""(.*)""")]
        public async Task WhenUserClicksGlobalButton(string button)
        {
            if (button.Equals("Home", StringComparison.OrdinalIgnoreCase)) {
                await SendRequestAndStoreResponse("/", HttpMethod.Get);
            } else if (button.Equals("Create New", StringComparison.OrdinalIgnoreCase)) {
                await SendRequestAndStoreResponse(NavigationSteps.page2 + "/create", HttpMethod.Get);
            } else if (button.Equals("Create", StringComparison.OrdinalIgnoreCase)) {
                await PostForm(NavigationSteps.page2 + "/create", GetFormData());
            } else {
                throw new ArgumentException($"Nieznany globalny przycisk: {button}");
            }
        }

        [When(@"użytkownik potwierdza usunięcie")]
        public async Task WhenUserConfirmsDeletion()
        {
            var url = NavigationSteps.page2.ToLower() switch
            {
                "categories" => "/categories/delete/1",
                "products" => "/products/delete/1",
                "orders" => "/orders/delete/1",
                _ => throw new ArgumentException($"Nieznana strona: {NavigationSteps.page2}")
            };

            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("CategoryId", "1")
            });

            var deleteResponse = await _client.PostAsync(url, formContent);
            postResponse = await deleteResponse.Content.ReadAsStringAsync();
            _ctx["response"] = deleteResponse;
        }

        private async Task SendRequestAndStoreResponse(string url, HttpMethod method)
        {
            var request = new HttpRequestMessage(method, url);
            var response = await _client.SendAsync(request);
            _ctx["response"] = response;
        }

        private async Task PostForm(string url, Dictionary<string, string> formData)
        {
            var content = new FormUrlEncodedContent(formData);
            var response = await _client.PostAsync(url, content);
            postResponse = await response.Content.ReadAsStringAsync();
            _ctx["response"] = response;
        }

        private Dictionary<string, string> GetFormData()
        {
            if (_ctx.TryGetValue("formData", out var formDataObj) && formDataObj is Dictionary<string, string> formData)
            {
                foreach(Object stuff in formData)
                {
                    Console.WriteLine(stuff.ToString());
                }
                return formData;
            }
            return new Dictionary<string, string>();
        }

        private string GetUrl(string entity, string button)
        {
            return button.ToLower() switch
            {
                "edit" => $"/{entity}/edit/1",
                "details" => $"/{entity}/details/1",
                "delete" => $"/{entity}/delete/1",
                _ => throw new ArgumentException($"Nieznany przycisk: {button}")
            };
        }
    }
}
