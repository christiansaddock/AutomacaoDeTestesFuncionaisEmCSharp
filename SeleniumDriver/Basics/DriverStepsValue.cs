using OpenQA.Selenium;
using SeleniumDriver.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumDriver.Basics
{
    public static class DriverStepsValue
    {
        private static IWebDriver _driver = DriverStepsFactory.driver;
        static IWebElement _element;

        public static void DadoOValorParaOcampo(string campo, string valor, bool enter = false)
        {
            _element = FindElement(campo);

            clearElement(_element);

            _element.SendKeys(valor);
            _element.SendKeys(Keys.Tab);

            if (enter)
                _element.SendKeys(Keys.Enter);
        }

        public static void DadoASelecaoDoValorParaOcampo(string campo, string valor)
        {
            _element = FindElement(campo);
            _element.Click();

            DriverUtils.WaitElement(_element);

            _element.SendKeys(valor);
            _element.SendKeys(Keys.Tab);
        }

        private static IWebElement FindElement(string nomeCampo)
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    return _driver.FindElement(By.Id(nomeCampo));
                }
                catch
                {
                    Thread.Sleep(100);
                }
            }
            throw new NullReferenceException("elemento não encontrado");
        }
               

        private static void clearElement(IWebElement el)
        {
            DriverUtils.WaitElement(el);

            try
            {
                el.Clear();
            }
            catch
            {
                try
                {
                    el.SendKeys(Keys.Home + Keys.Shift + Keys.End + Keys.Delete + Keys.Tab);
                }
                catch
                {
                    //throw new NullReferenceException("elemento não pode ser limpo");
                }
            }
            return;
        }
    }
}
