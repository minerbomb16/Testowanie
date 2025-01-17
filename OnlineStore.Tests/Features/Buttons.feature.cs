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
    [NUnit.Framework.DescriptionAttribute("Testowanie przycisków Edit, Details i Delete")]
    public partial class TestowaniePrzyciskowEditDetailsIDeleteFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Buttons.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Testowanie przycisków Edit, Details i Delete", null, ProgrammingLanguage.CSharp, featureTags);
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
        [NUnit.Framework.DescriptionAttribute("Przycisk <Button> dla pierwszego elementu")]
        [NUnit.Framework.TestCaseAttribute("categories", "Edit", "edit", null)]
        [NUnit.Framework.TestCaseAttribute("categories", "Details", "details", null)]
        [NUnit.Framework.TestCaseAttribute("categories", "Delete", "delete", null)]
        [NUnit.Framework.TestCaseAttribute("products", "Edit", "edit", null)]
        [NUnit.Framework.TestCaseAttribute("products", "Details", "details", null)]
        [NUnit.Framework.TestCaseAttribute("products", "Delete", "delete", null)]
        [NUnit.Framework.TestCaseAttribute("orders", "Edit", "edit", null)]
        [NUnit.Framework.TestCaseAttribute("orders", "Details", "details", null)]
        [NUnit.Framework.TestCaseAttribute("orders", "Delete", "delete", null)]
        public void PrzyciskButtonDlaPierwszegoElementu(string page, string button, string urlSuffix, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Page", page);
            argumentsOfScenario.Add("Button", button);
            argumentsOfScenario.Add("urlSuffix", urlSuffix);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Przycisk <Button> dla pierwszego elementu", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
    testRunner.Given(string.Format("użytkownik otwiera stronę \"{0}\"", page), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
    testRunner.When(string.Format("użytkownik klika przycisk \"{0}\" dla pierwszego elementu", button), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
    testRunner.Then(string.Format("użytkownik powinien zostać przeniesiony na stronę \"/{0}/{1}/1\"", page, urlSuffix), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
