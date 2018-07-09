using OpenQA.Selenium;

namespace OctopusProject.PageObjects
{
    internal interface IJavascriptExecutor
    {
        void ExecuteScript(string v, IWebElement lnkFCAconsent);
    }
}