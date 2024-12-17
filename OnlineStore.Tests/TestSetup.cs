using NUnit.Framework;

[SetUpFixture]
public class TestSetup
{
    [OneTimeSetUp]
    public void GlobalSetup()
    {
        // Konfiguracja przed testami
    }

    [OneTimeTearDown]
    public void GlobalTeardown()
    {
        // Czyszczenie środowiska testowego
    }
}
