using System;
using System.Configuration;
using System.Threading;
using NUnit.Framework;
using OctopusProject.Control_Libs;
using OctopusProject.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using static OctopusProject.PeoplePageFunctionalitySteps;

namespace OctopusProject
{
    [Binding]
    class PeoplePageFunctionalitySteps : PropertiesCollection
    {
        [Given(@"I am on Octopus Investments Poeple page of website")]
        public void GivenIAmOnOctopusInvestmentsPoeplePageOfWebsite()
        {
            IWebDriver driver = PropertiesCollection.driversetup();
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("incognito");
            driver.Navigate().GoToUrl("https://octopusinvestments.com/adviser/about-us/our-people/");
            OctopusPeoplePage page = new OctopusPeoplePage(driver);
            Thread.Sleep(50);
            page.acceptcookies();
            page.FCAconsentwait();
            
        }

        [When(@"I search (.*)")]
        public void WhenISearchKeywordAs(string key)
        {
            OctopusPeoplePage page = new OctopusPeoplePage(driver);
            page.search_using_table_ascending(key);
        }

        [Then(@"I am presented with No result displayed")]
        public void ThenIAmPresentedWithNoResultDisplayed()
        {
            OctopusPeoplePage page = new OctopusPeoplePage(driver);
            string displayed_text = page.getNoResultText();
            Assert.IsTrue(displayed_text.Equals("No results found"), displayed_text + "doesn't show'No results found'");
            driver.Quit();
        }

        [Then(@"I am presented with Result matching the test data")]
        public void ThenIAmPresentedWithResultMatchingTheTestData()
        {
            OctopusPeoplePage page = new OctopusPeoplePage(driver);
            string name_displayed = page.persondisplayed();
            if (name_displayed != null)
            {
                Console.WriteLine("Team Members Displayed");
            }
            else
            {
                Console.WriteLine("No Team to display by this name");
            }
            driver.Quit();
        }
        
        [When(@"I  select a checkbox as per test data to select (.*)")]
        public void WhenISelectACheckboxAsPerTestDataToSelectBusinessDevelopmentTeam(string Team)
        {
            OctopusPeoplePage page = new OctopusPeoplePage(driver);
            page.TeamSelect(Team);
            driver.Quit();
        }
    }
}
