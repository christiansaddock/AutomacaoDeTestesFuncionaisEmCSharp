using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumDriver.Basics;

namespace SeleniumDriver.PageObjects
{
    public static class DriverCheckout
    {
        public static IWebDriver _driver = DriverStepsFactory.driver;

        public static void DadoQueAceitoOsTermosDeServico()
        {
            DriverStepsAction.QuandoClicarNoCheckbox("I agree to the terms of service and will adhere to them unconditionally.");
        }

        public static void EntaoOValorTotalDaCompraDeveSer(string valor)
        {
            string valorTela = _driver.FindElement(By.Id("total_price")).Text;

            Assert.AreEqual(valor, valorTela);
        }
    }
}
