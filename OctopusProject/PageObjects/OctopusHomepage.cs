using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OctopusProject.Control_Libs;
using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace OctopusProject.PageObjects
{
    class OctopusHomepage : PropertiesCollection
    {
        //Constructor:
        public OctopusHomepage(IWebDriver driver)
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        //Octopus About Us Link
        [FindsBy(How = How.Id, Using = "menu-item-20")]
        public IWebElement lnkAboutUs { get; set; }

        //Methods for page:

        //Search Name in text box Display Ascending
        public OctopusAboutUspage OpenAboutUs()
        {
            SetMethods.Click(lnkAboutUs);
            return new OctopusAboutUspage();
        }
    }
}
