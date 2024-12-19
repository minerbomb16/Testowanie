using NUnit.Framework;

[SetUpFixture]
public class TestSetup
{
    [OneTimeSetUp]
    public void GlobalSetup()
    {
        // Ewentualne globalne ustawienia testów
    }

    [OneTimeTearDown]
    public void GlobalTeardown()
    {
        // Ewentualne globalne czyszczenie
    }
}
