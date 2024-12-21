using TechTalk.SpecFlow;

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
            if (!_ctx.TryGetValue("formData", out Dictionary<string, string> formData)) {
                formData = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            }
            if (NavigationSteps.page2.Equals("Products", StringComparison.OrdinalIgnoreCase)) {
                if (fieldName.Equals("Description", StringComparison.OrdinalIgnoreCase))
                    fieldName = "ProductDetail.Description";
                else if (fieldName.Equals("Specifications", StringComparison.OrdinalIgnoreCase))
                    fieldName = "ProductDetail.Specifications";
            }
            if (NavigationSteps.page2.Equals("Orders", StringComparison.OrdinalIgnoreCase)) {
                if (fieldName.Equals("productIds", StringComparison.OrdinalIgnoreCase)) {
                    fieldName = "productIds";
                } else if (fieldName.Equals("quantities", StringComparison.OrdinalIgnoreCase)) {
                    fieldName = "quantities";
                }
            }
            formData[fieldName] = fieldValue;
            _ctx["formData"] = formData;
        }
    }
}
