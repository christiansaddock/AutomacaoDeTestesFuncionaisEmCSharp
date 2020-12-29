using OpenQA.Selenium;
using System.Configuration;

namespace SeleniumDriver.Basics
{
    public static class DriverStepsNavigate
    {
        private static IWebDriver _driver = DriverStepsFactory.driver;

        public static void DadoAurl(string URL)
        {
            try
            {
                _driver.Url = ConfigurationManager.AppSettings["URL"] + URL;
            }
            catch
            {
                _driver.Url = URL;
            }            
        }
    }
}
