using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace OctopusProject
{
    public class PropertiesCollection
    {
        public static IWebDriver driver { get; set; }

        public static IWebDriver driversetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().PageLoad = (TimeSpan.FromSeconds(35));
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            return driver;
        }
    }
}
