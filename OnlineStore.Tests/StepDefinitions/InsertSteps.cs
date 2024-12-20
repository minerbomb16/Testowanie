using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;

namespace OnlineStore.Tests.StepDefinitions
{
    [Binding]
    public class InsertSteps
    {
        private readonly ScenarioContext _ctx;

        public InsertSteps(ScenarioContext scenarioContext)
        {
            _ctx = scenarioContext;
        }

        [When(@"użytkownik wpisuje w polu ""(.*)"" wartość ""(.*)""")]
        public void WhenUserInsertsValueInField(string fieldName, string fieldValue)
        {
            if (!_ctx.TryGetValue("formData", out Dictionary<string, string> formData))
            {
                formData = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            }

            // Sprawdź, czy aktualnie testujemy tworzenie produktu
            // Jeśli tak, dla Description i Specifications używamy poprawnych kluczy
            if (NavigationSteps.page2.Equals("Products", StringComparison.OrdinalIgnoreCase))
            {
                if (fieldName.Equals("Description", StringComparison.OrdinalIgnoreCase))
                    fieldName = "ProductDetail.Description";
                else if (fieldName.Equals("Specifications", StringComparison.OrdinalIgnoreCase))
                    fieldName = "ProductDetail.Specifications";
            }

            formData[fieldName] = fieldValue;
            _ctx["formData"] = formData;
        }
    }
}
