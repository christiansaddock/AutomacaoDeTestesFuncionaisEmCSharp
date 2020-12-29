using OpenQA.Selenium;
using System;

namespace SeleniumDriver.Basics
{
    public static class DriverStepsAction
    {
        private static IWebDriver _driver = DriverStepsFactory.driver;

        public static void QuandoClicarNoBotao(string botao)
        {
            for (int i = 0; i < 10; i++)
            {
                foreach (IWebElement el in _driver.FindElements(By.ClassName("button")))
                    if (el.Text == botao)
                    {
                        el.Click();
                        return;
                    }
                foreach (IWebElement el in _driver.FindElements(By.ClassName("btn")))
                {
                    if (el.Text == botao)
                    {
                        el.Click();
                        return;
                    }
                    try
                    {
                        if (el.GetAttribute("title") == botao)
                        {
                            el.Click();
                            return;
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
                try
                {
                    _driver.FindElement(By.Id(botao)).Click();
                    return;
                }
                catch
                {
                }
            }
            throw new NullReferenceException(botao + " não encontrado");
        }
        public static void QuandoClicarNoCheckbox(string checkbox)
        {
            for (int i = 0; i < 10; i++)
            {
                foreach (IWebElement el in _driver.FindElements(By.ClassName("checkbox")))
                    if (el.Text == checkbox)
                    {
                        el.Click();
                        return;
                    }
            }
            throw new NullReferenceException("checkbox não encontrado");
        }
    }
}
