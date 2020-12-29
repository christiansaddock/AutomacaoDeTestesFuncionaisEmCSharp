using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumDriver.Utils
{
    public static class DriverUtils
    {
        public static IWebDriver _driver = DriverStepsFactory.driver;

        public static void WaitElement(IWebElement element)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1));
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(TimeoutException));
                wait.Until((driver) =>
                {
                    return !element.Displayed == true;
                });
            }
            catch
            {
                return;
            }
        }

        public static void WaitPageLoaded()
        {
            Thread.Sleep(250);
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 10));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }

        public static string EmailRandon()
        {
            Random random = new Random();
            return string.Format("qa{0:0000}@test.com", random.Next(10000));
        }
    }
}
