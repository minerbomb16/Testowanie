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
    [NUnit.Framework.DescriptionAttribute("Tworzenie nowej kategorii")]
    public partial class TworzenieNowejKategoriiFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Create.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Tworzenie nowej kategorii", "  Jako użytkownik\r\n  Chcę móc utworzyć nową kategorię\r\n  Aby poszerzyć katalog pr" +
                    "oduktów", ProgrammingLanguage.CSharp, featureTags);
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
#line 6
  #line hidden
#line 7
    testRunner.Given("baza danych zawiera 3 kategorie, 3 produkty i 3 zamówienia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Utworzenie kategorii")]
        [NUnit.Framework.TestCaseAttribute("Category 4", null)]
        [NUnit.Framework.TestCaseAttribute("ąść", null)]
        [NUnit.Framework.TestCaseAttribute("!@#$%^&*()", null)]
        public void UtworzenieKategorii(string name, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Name", name);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Utworzenie kategorii", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 9
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
  this.FeatureBackground();
#line hidden
#line 10
    testRunner.Given(string.Format("w bazie danych nie ma kategorii \"{0}\"", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 11
    testRunner.And("użytkownik otwiera stronę \"Categories\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
    testRunner.When("użytkownik klika przycisk \"Create New\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
    testRunner.And(string.Format("użytkownik wpisuje w polu \"Name\" wartość \"{0}\"", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
    testRunner.And("użytkownik klika przycisk \"Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
    testRunner.Then(string.Format("w bazie danych powinna być kategoria \"{0}\"", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 16
    testRunner.And("użytkownik powinien zobaczyć stronę \"Categories\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Walidacja tworzenia kategorii z nieprawidłowymi danymi")]
        [NUnit.Framework.TestCaseAttribute("", "The Name field is required.", null)]
        [NUnit.Framework.TestCaseAttribute("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "Name too long.", null)]
        public void WalidacjaTworzeniaKategoriiZNieprawidlowymiDanymi(string name, string errorMessage, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Name", name);
            argumentsOfScenario.Add("ErrorMessage", errorMessage);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Walidacja tworzenia kategorii z nieprawidłowymi danymi", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 24
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
  this.FeatureBackground();
#line hidden
#line 25
    testRunner.Given("użytkownik otwiera stronę \"Categories\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 26
    testRunner.When("użytkownik klika przycisk \"Create New\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
    testRunner.And(string.Format("użytkownik wpisuje w polu \"Name\" wartość \"{0}\"", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
    testRunner.And("użytkownik klika przycisk \"Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
    testRunner.Then(string.Format("użytkownik powinien zobaczyć komunikat o błędzie \"{0}\"", errorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
    testRunner.And("użytkownik powinien zobaczyć stronę \"Categories/Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Utworzenie produktu")]
        [NUnit.Framework.TestCaseAttribute("Sausage", "7", "1", "very tasty", "makes you less hungry", null)]
        [NUnit.Framework.TestCaseAttribute("TV", "5000", "2", "very expensive", "makes you even dumber", null)]
        [NUnit.Framework.TestCaseAttribute("Nigger", "2137", "3", "very black", "works for free", null)]
        public void UtworzenieProduktu(string name, string price, string categoryId, string description, string specifications, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Name", name);
            argumentsOfScenario.Add("Price", price);
            argumentsOfScenario.Add("CategoryId", categoryId);
            argumentsOfScenario.Add("Description", description);
            argumentsOfScenario.Add("Specifications", specifications);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Utworzenie produktu", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 37
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
  this.FeatureBackground();
#line hidden
#line 38
  testRunner.Given(string.Format("w bazie danych nie ma produktu \"{0}\"", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 39
  testRunner.And("użytkownik otwiera stronę \"Products\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
  testRunner.When("użytkownik klika przycisk \"Create New\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 41
  testRunner.And(string.Format("użytkownik wpisuje w polu \"Name\" wartość \"{0}\"", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
  testRunner.And(string.Format("użytkownik wpisuje w polu \"Price\" wartość \"{0}\"", price), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
  testRunner.And(string.Format("użytkownik wpisuje w polu \"CategoryId\" wartość \"{0}\"", categoryId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
  testRunner.And(string.Format("użytkownik wpisuje w polu \"Description\" wartość \"{0}\"", description), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
  testRunner.And(string.Format("użytkownik wpisuje w polu \"Specifications\" wartość \"{0}\"", specifications), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
  testRunner.And("użytkownik klika przycisk \"Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
  testRunner.Then(string.Format("w bazie danych powinien być produkt \"{0}\"", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
  testRunner.And("użytkownik powinien zobaczyć stronę \"Products\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Walidacja tworzenia produktu z nieprawidłowymi danymi")]
        [NUnit.Framework.TestCaseAttribute("", "1", "1", "Opis produktu 1", "Specyfikacja produktu 1", "Name is required.", null)]
        [NUnit.Framework.TestCaseAttribute("Product 2", "-1", "2", "Opis produktu 2", "Specyfikacja produktu 2", "Price must be greater than zero.", null)]
        [NUnit.Framework.TestCaseAttribute("Product 3", "1", "3", "", "Specyfikacja produktu 3", "Description is required.", null)]
        [NUnit.Framework.TestCaseAttribute("Product 4", "1", "1", "Opis produktu 4", "", "Specifications are required.", null)]
        public void WalidacjaTworzeniaProduktuZNieprawidlowymiDanymi(string name, string price, string categoryId, string description, string specifications, string errorMessage, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Name", name);
            argumentsOfScenario.Add("Price", price);
            argumentsOfScenario.Add("CategoryId", categoryId);
            argumentsOfScenario.Add("Description", description);
            argumentsOfScenario.Add("Specifications", specifications);
            argumentsOfScenario.Add("ErrorMessage", errorMessage);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Walidacja tworzenia produktu z nieprawidłowymi danymi", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 56
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
  this.FeatureBackground();
#line hidden
#line 57
  testRunner.Given("użytkownik otwiera stronę \"Products\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 58
  testRunner.When("użytkownik klika przycisk \"Create New\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
  testRunner.And(string.Format("użytkownik wpisuje w polu \"Name\" wartość \"{0}\"", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
  testRunner.And(string.Format("użytkownik wpisuje w polu \"Price\" wartość \"{0}\"", price), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
  testRunner.And(string.Format("użytkownik wpisuje w polu \"CategoryId\" wartość \"{0}\"", categoryId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
  testRunner.And(string.Format("użytkownik wpisuje w polu \"Description\" wartość \"{0}\"", description), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
  testRunner.And(string.Format("użytkownik wpisuje w polu \"Specifications\" wartość \"{0}\"", specifications), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
  testRunner.And("użytkownik klika przycisk \"Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
  testRunner.Then(string.Format("użytkownik powinien zobaczyć komunikat o błędzie \"{0}\"", errorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 66
  testRunner.And("użytkownik powinien zobaczyć stronę \"Products/Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
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
#line 75
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
  this.FeatureBackground();
#line hidden
#line 76
  testRunner.Given(string.Format("w bazie danych nie ma zamówienia dla \"{0}\"", customerName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 77
  testRunner.And("użytkownik otwiera stronę \"Orders\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 78
  testRunner.When("użytkownik klika przycisk \"Create New\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 79
  testRunner.And(string.Format("użytkownik wpisuje w polu \"CustomerName\" wartość \"{0}\"", customerName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 80
  testRunner.And(string.Format("użytkownik wpisuje w polu \"OrderDate\" wartość \"{0}\"", orderDate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 81
  testRunner.And(string.Format("użytkownik wpisuje w polu \"productIds\" wartość \"{0}\"", productIds), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 82
  testRunner.And(string.Format("użytkownik wpisuje w polu \"quantities\" wartość \"{0}\"", quantities), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 83
  testRunner.And("użytkownik klika przycisk \"Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 84
  testRunner.Then(string.Format("w bazie danych powinno być zamówienie dla \"{0}\"", customerName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 85
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
#line 93
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
  this.FeatureBackground();
#line hidden
#line 94
  testRunner.Given(string.Format("w bazie danych nie ma zamówienia dla \"{0}\"", customerName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 95
  testRunner.And("użytkownik otwiera stronę \"Orders\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 96
  testRunner.When("użytkownik klika przycisk \"Create New\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 97
  testRunner.And(string.Format("użytkownik wpisuje w polu \"CustomerName\" wartość \"{0}\"", customerName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
  testRunner.And(string.Format("użytkownik wpisuje w polu \"OrderDate\" wartość \"{0}\"", orderDate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 99
  testRunner.And(string.Format("użytkownik wpisuje w polu \"productIds\" wartość \"{0}\"", productIds), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 100
  testRunner.And(string.Format("użytkownik wpisuje w polu \"quantities\" wartość \"{0}\"", quantities), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 101
  testRunner.And("użytkownik klika przycisk \"Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 102
  testRunner.Then(string.Format("użytkownik powinien zobaczyć komunikat o błędzie \"{0}\"", errorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 103
  testRunner.And("użytkownik powinien zobaczyć stronę \"Orders/Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
