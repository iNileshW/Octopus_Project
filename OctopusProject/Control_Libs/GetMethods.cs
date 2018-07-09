using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OctopusProject.Control_Libs
{
    class GetMethods
    {
        //Get Text
        public static string GetText(IWebElement element, string value)
        {
            string displayedtext = element.GetAttribute(value);
            return displayedtext;
        }

        //Get Dropdown Text
        public static string GetddlText(IWebElement element, string value)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}
