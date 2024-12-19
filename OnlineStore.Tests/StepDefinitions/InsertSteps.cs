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

            formData[fieldName] = fieldValue;
            _ctx["formData"] = formData;
        }

    }
}
