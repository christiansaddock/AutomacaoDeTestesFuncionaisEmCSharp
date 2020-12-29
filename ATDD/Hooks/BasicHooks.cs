using TechTalk.SpecFlow;
using System.Configuration;
using SeleniumDriver;
using SeleniumDriver.Basics;

namespace ATDD.Hooks
{
    [Binding]
    public sealed class BasicHooks
    {
        [BeforeTestRun]
        public static void AssemblyInitialize()
        {
            //DriverStepsFactory.InitBrowser(ConfigurationManager.AppSettings["Browser"].ToUpper(), ConfigurationManager.AppSettings["ModoOculto"].ToUpper());
            DriverStepsFactory.InitBrowser("Chrome", "Não");

            //DriverStepsNavigate.DadoAurl(ConfigurationManager.AppSettings["URLbase"]);
            DriverStepsNavigate.DadoAurl("http://automationpractice.com/");
        }

        [AfterTestRun]
        public static void AfterRunner()
        {
            DriverStepsFactory.CloseAllDrivers();
        }       
    }
}