using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumDriver.Basics;

namespace SeleniumDriver.PageObjects
{
    public static class DriverCheckout
    {
        public static IWebDriver _driver = DriverStepsFactory.driver;
        static IWebElement _element;

        public static void DadoQueAceitoOsTermosDeServico()
        {
            DriverStepsAction.QuandoClicarNoCheckbox("I agree to the terms of service and will adhere to them unconditionally.");
        }

        public static void EntaoOValorTotalDaCompraDeveSer(string valor)
        {
            Utils.DriverUtils.WaitPageLoaded();

            try
            {
                _element = _driver.FindElement(By.Id("total_price"));
            }
            catch
            {
                try
                {
                    _element = _driver.FindElement(By.Id("our_price_display"));
                }
                catch
                {
                    throw new NullReferenceException("elemento não encontrado");
                }
            }

            Assert.AreEqual(valor, _element.Text);
        }
    }
}
