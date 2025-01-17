﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace OnlineStore.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Operacje na zamówieniach")]
    public partial class OperacjeNaZamowieniachFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Order.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Operacje na zamówieniach", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 2
  #line hidden
#line 3
    testRunner.Given("baza danych zawiera 3 kategorie, 3 produkty i 3 zamówienia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Utworzenie zamówienia")]
        [NUnit.Framework.TestCaseAttribute("Paweł", "01.02.2003", "1", "3", null)]
        [NUnit.Framework.TestCaseAttribute("Czesio", "05.07.2004", "2", "4", null)]
        [NUnit.Framework.TestCaseAttribute("Stodolski", "12.11.2001", "3", "5", null)]
        public void UtworzenieZamowienia(string customerName, string orderDate, string productIds, string quantities, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("CustomerName", customerName);
            argumentsOfScenario.Add("OrderDate", orderDate);
            argumentsOfScenario.Add("productIds", productIds);
            argumentsOfScenario.Add("quantities", quantities);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Utworzenie zamówienia", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
  this.FeatureBackground();
#line hidden
#line 6
  testRunner.Given(string.Format("w bazie danych nie ma zamówienia dla \"{0}\"", customerName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
  testRunner.And("użytkownik otwiera stronę \"Orders\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
  testRunner.When("użytkownik klika przycisk \"Create New\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
  testRunner.And(string.Format("użytkownik wpisuje w polu \"CustomerName\" wartość \"{0}\"", customerName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
  testRunner.And(string.Format("użytkownik wpisuje w polu \"OrderDate\" wartość \"{0}\"", orderDate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
  testRunner.And(string.Format("użytkownik wpisuje w polu \"productIds\" wartość \"{0}\"", productIds), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
  testRunner.And(string.Format("użytkownik wpisuje w polu \"quantities\" wartość \"{0}\"", quantities), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
  testRunner.And("użytkownik klika przycisk \"Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
  testRunner.Then(string.Format("w bazie danych powinno być zamówienie dla \"{0}\"", customerName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 15
  testRunner.And("użytkownik powinien zobaczyć stronę \"Orders\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Walidacja utworzenia zamówienia z nieprawidłowymi danymi")]
        [NUnit.Framework.TestCaseAttribute("", "01.02.2003", "1", "3", "The CustomerName field is required.", null)]
        [NUnit.Framework.TestCaseAttribute("Paweł", "", "2", "4", "The value &#x27;&#x27; is invalid.", null)]
        [NUnit.Framework.TestCaseAttribute("Czesio", "04.mm.rrrr", "2", "4", "The value &#x27;04.mm.rrrr&#x27; is not valid for OrderDate.", null)]
        [NUnit.Framework.TestCaseAttribute("Stodolski", "12.11.2001", "-- Select Product --", "5", "", null)]
        [NUnit.Framework.TestCaseAttribute("Maciuś", "12.11.2001", "1", "0", "", null)]
        public void WalidacjaUtworzeniaZamowieniaZNieprawidlowymiDanymi(string customerName, string orderDate, string productIds, string quantities, string errorMessage, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("CustomerName", customerName);
            argumentsOfScenario.Add("OrderDate", orderDate);
            argumentsOfScenario.Add("productIds", productIds);
            argumentsOfScenario.Add("quantities", quantities);
            argumentsOfScenario.Add("ErrorMessage", errorMessage);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Walidacja utworzenia zamówienia z nieprawidłowymi danymi", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 23
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
  this.FeatureBackground();
#line hidden
#line 24
  testRunner.Given(string.Format("w bazie danych nie ma zamówienia dla \"{0}\"", customerName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 25
  testRunner.And("użytkownik otwiera stronę \"Orders\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
  testRunner.When("użytkownik klika przycisk \"Create New\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
  testRunner.And(string.Format("użytkownik wpisuje w polu \"CustomerName\" wartość \"{0}\"", customerName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
  testRunner.And(string.Format("użytkownik wpisuje w polu \"OrderDate\" wartość \"{0}\"", orderDate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
  testRunner.And(string.Format("użytkownik wpisuje w polu \"productIds\" wartość \"{0}\"", productIds), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
  testRunner.And(string.Format("użytkownik wpisuje w polu \"quantities\" wartość \"{0}\"", quantities), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
  testRunner.And("użytkownik klika przycisk \"Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
  testRunner.Then(string.Format("użytkownik powinien zobaczyć komunikat o błędzie \"{0}\"", errorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 33
  testRunner.And("użytkownik powinien zobaczyć stronę \"Orders/Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Usunięcie zamówienia dla \"Customer 1\"")]
        public void UsuniecieZamowieniaDlaCustomer1()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Usunięcie zamówienia dla \"Customer 1\"", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 43
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
  this.FeatureBackground();
#line hidden
#line 44
    testRunner.Given("zamówienie dla \"Customer 1\" istnieje w bazie danych", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 45
    testRunner.And("użytkownik otwiera stronę \"Orders\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
    testRunner.When("użytkownik klika przycisk \"Delete\" dla pierwszego elementu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
    testRunner.And("użytkownik potwierdza usunięcie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
    testRunner.Then("w bazie danych nie powinna być zamówienie dla \"Customer 1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
    testRunner.And("użytkownik powinien zobaczyć stronę \"Orders\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
