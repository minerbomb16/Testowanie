using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using OnlineStore.Domain.Models;

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

            // Pobieramy fabrykę z ScenarioContext
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
            if (button.Equals("Home", StringComparison.OrdinalIgnoreCase))
            {
                await SendRequestAndStoreResponse("/", HttpMethod.Get);
            }
            else if (button.Equals("Create New", StringComparison.OrdinalIgnoreCase))
            {
                await SendRequestAndStoreResponse(NavigationSteps.page2 + "/create", HttpMethod.Get);
            }
            else if (button.Equals("Create", StringComparison.OrdinalIgnoreCase))
            {
                await PostForm(NavigationSteps.page2 + "/create", GetFormData());
            }
            else
            {
                throw new ArgumentException($"Nieznany globalny przycisk: {button}");
            }
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
