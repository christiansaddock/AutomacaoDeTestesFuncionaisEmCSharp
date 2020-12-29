using OpenQA.Selenium;
using System.Configuration;

namespace SeleniumDriver.Basics
{
    public static class DriverStepsNavigate
    {
        private static IWebDriver driver = DriverStepsFactory.driver;

        public static void DadoAurl(string URL)
        {
            try
            {
                driver.Url = ConfigurationManager.AppSettings["URL"] + URL;
            }
            catch
            {
                driver.Url = URL;
            }            
        }
    }
}
