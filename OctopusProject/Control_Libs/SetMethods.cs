using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OctopusProject.Control_Libs
{
    class SetMethods : PropertiesCollection
    {
        public static IList<IWebElement> TreeItems { get; private set; }

        //Enter Text
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //Click
        public static void Click(IWebElement element)
        {
            element.Click();
        }

        //Explicit wait Click
        //public static void ExplicitWaitClick(IWebDriver driver, IWebElement element)
        //{
        //    //new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(ElementNotVisibleException).Click();

        //    //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        //    //IWebElement element1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((IWebElement)element.));



        //    //

        //    new WebDriverWait(driver, 5).until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable.element;
        //    element.Click();
        //    //
        //    var wait = new DefaultWait<IWebDriver>(driver)
        //    {
        //        Timeout = TimeSpan.FromSeconds(10),
        //        //Message = "Dude, where's my element?",
        //        PollingInterval = TimeSpan.FromSeconds(1)
        //    };
        //    wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

        //    var myElement = wait.Until(ElementIsVisible(element));
        //}

        //Select Dropdown
        public static void Selectddl(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }

        //Select Dropdown
        public static void Selectchkbox(IWebElement element)
        {
            element.Click();
        }
    }
}
