using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoSelenium.demoProject
{
    internal static class demoSelenium
    {
        public static void Main()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.5elementslearning.dev/demosite";
            driver.FindElement(By.LinkText("My Account")).Click();
            driver.Quit();
        }
    }
}
