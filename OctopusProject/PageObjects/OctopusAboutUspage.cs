using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OctopusProject.Control_Libs;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OctopusProject.PageObjects
{
    class OctopusAboutUspage : PropertiesCollection
    {
        //Constructor:
        public OctopusAboutUspage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        //Octopus View Our People Button
        [FindsBy(How = How.XPath, Using = "//a[@class='arrow-link--purple']")]
        public IWebElement lnkPeople { get; set; }

        //Methods for page:

        //Search Name in text box Display Ascending
        public OctopusPeoplePage OpenPeoplePage()
        {
            SetMethods.Click(lnkPeople);
            return new OctopusPeoplePage();
        }
    }
}
