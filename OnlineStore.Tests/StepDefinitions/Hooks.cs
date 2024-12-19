using TechTalk.SpecFlow;
using OnlineStore.Tests.Infrastructure;

[Binding]
public class Hooks
{
    private readonly ScenarioContext _scenarioContext;
    private CustomWebApplicationFactory _factory;
    private TestDatabase _testDatabase;

    public Hooks(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [BeforeScenario]
    public void BeforeScenario()
    {
        // Tworzymy fabrykę aplikacji testowej
        _factory = new CustomWebApplicationFactory();

        // Tworzymy TestDatabase z tym samym ConnectionString, co w fabryce
        _testDatabase = new TestDatabase();
        _testDatabase.Reset(); // Czyści i seeduje bazę przed scenariuszem

        // Zapamiętujemy w ScenarioContext
        _scenarioContext["factory"] = _factory;
        _scenarioContext["testDatabase"] = _testDatabase;
    }

    [AfterScenario]
    public void AfterScenario()
    {
        _testDatabase.Dispose();
    }
}
