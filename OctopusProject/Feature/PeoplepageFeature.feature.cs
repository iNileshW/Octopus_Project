﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace OctopusProject.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("People page functionality")]
    public partial class PeoplePageFunctionalityFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PeoplepageFeature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "People page functionality", "\tIn order to validate people page \r\n\tAs a tester \r\n\tI want to check the search fu" +
                    "nctionality of people", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("People page search functionality validation with invalid data (-ve Case)")]
        [NUnit.Framework.CategoryAttribute("SmokeTest")]
        [NUnit.Framework.TestCaseAttribute("dsfklds", null)]
        [NUnit.Framework.TestCaseAttribute("asdhjjk", null)]
        public virtual void PeoplePageSearchFunctionalityValidationWithInvalidData_VeCase(string keyword, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SmokeTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("People page search functionality validation with invalid data (-ve Case)", @__tags);
#line 7
 this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I am on Octopus Investments Poeple page of website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When(string.Format("I search {0}", keyword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("I am presented with No result displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("People page search functionality validation with valid data (+ve Case)")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.TestCaseAttribute("Adam", null)]
        [NUnit.Framework.TestCaseAttribute("David", null)]
        [NUnit.Framework.TestCaseAttribute("John", null)]
        [NUnit.Framework.TestCaseAttribute("Mike", null)]
        [NUnit.Framework.TestCaseAttribute("James", null)]
        public virtual void PeoplePageSearchFunctionalityValidationWithValidDataVeCase(string name, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegressionTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("People page search functionality validation with valid data (+ve Case)", @__tags);
#line 18
 this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.Given("I am on Octopus Investments Poeple page of website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
 testRunner.When(string.Format("I search {0}", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("I am presented with Result matching the test data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Team Selection validation")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.TestCaseAttribute("Business Development team", null)]
        [NUnit.Framework.TestCaseAttribute("Client Relations team", null)]
        [NUnit.Framework.TestCaseAttribute("Corporate Development team", null)]
        [NUnit.Framework.TestCaseAttribute("Energy team", null)]
        [NUnit.Framework.TestCaseAttribute("Institutional Funds team", null)]
        [NUnit.Framework.TestCaseAttribute("Intermediate Capital team", null)]
        [NUnit.Framework.TestCaseAttribute("Multi Manager team", null)]
        public virtual void TeamSelectionValidation(string team, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegressionTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Team Selection validation", @__tags);
#line 32
 this.ScenarioSetup(scenarioInfo);
#line 33
 testRunner.Given("I am on Octopus Investments Poeple page of website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
 testRunner.When(string.Format("I  select a checkbox as per test data to select {0}", team), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("I am presented with Result matching the test data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Descending order display validation")]
        public virtual void DescendingOrderDisplayValidation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Descending order display validation", ((string[])(null)));
#line 46
 this.ScenarioSetup(scenarioInfo);
#line 47
 testRunner.Given("I am on Octopus Investments Poeple page of website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
 testRunner.When("I select descending sort in drop down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.Then("I am presented with results in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validation of members page displayed")]
        public virtual void ValidationOfMembersPageDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validation of members page displayed", ((string[])(null)));
#line 51
 this.ScenarioSetup(scenarioInfo);
#line 52
 testRunner.Given("I am on Octopus Investments Poeple page of website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 53
 testRunner.When("I click on image of member", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.Then("I am presented with members page giving information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validation of Displaying page in larger Font")]
        public virtual void ValidationOfDisplayingPageInLargerFont()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validation of Displaying page in larger Font", ((string[])(null)));
#line 56
 this.ScenarioSetup(scenarioInfo);
#line 57
 testRunner.Given("I am on Octopus Investments Poeple page of website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 58
 testRunner.When("I click on enlarge font", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.Then("the page is displayed with bigger font", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validation of Displaying page in Smaller Font")]
        public virtual void ValidationOfDisplayingPageInSmallerFont()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validation of Displaying page in Smaller Font", ((string[])(null)));
#line 61
 this.ScenarioSetup(scenarioInfo);
#line 62
 testRunner.Given("I am on Octopus Investments Poeple page of website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 63
 testRunner.When("I click on reduce font size", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.Then("the page is displayed with smaller size font", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validation of Team Display for two teams")]
        public virtual void ValidationOfTeamDisplayForTwoTeams()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validation of Team Display for two teams", ((string[])(null)));
#line 66
 this.ScenarioSetup(scenarioInfo);
#line 67
 testRunner.Given("I am on Octopus Investments Poeple page of website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 68
 testRunner.When("I select two checkboxes of teams", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.Then("I am presented with members of those two team", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validation of connetion link image")]
        public virtual void ValidationOfConnetionLinkImage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validation of connetion link image", ((string[])(null)));
#line 71
 this.ScenarioSetup(scenarioInfo);
#line 72
 testRunner.Given("I am on Octopus Investments Poeple page of website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 73
 testRunner.When("I click on Making the connection link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.Then("I am presented with Octopus Investments Poeple page of website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Website Search functionality validation with invalid data")]
        public virtual void WebsiteSearchFunctionalityValidationWithInvalidData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Website Search functionality validation with invalid data", ((string[])(null)));
#line 76
 this.ScenarioSetup(scenarioInfo);
#line 77
 testRunner.Given("I am on Octopus Investments Poeple page of website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 78
 testRunner.When("I enter invalid data in search box of website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.Then("the page is displayed with no results found", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
