﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDriver.PageObjects
{
    public static class DriverVitrine
    {
        public static IWebDriver _driver = DriverStepsFactory.driver;

        public static void DadoABuscaDoItem(string item)
        {
            Basics.DriverStepsValue.DadoOValorParaOcampo("search_query_top", item, true);
        }

        public static void QuandoSelecionarOItem(string item)
        {
            foreach (IWebElement el in _driver.FindElements(By.ClassName("product_img_link")))
                try
                {
                    if (el.GetAttribute("title") == item)
                    {
                        el.Click();
                        return;
                    }
                }
                catch
                {
                    throw new NullReferenceException(item + " não encontrado");
                }
        }

        public static void QuandoClicarNoCarrinho()
        {
            _driver.FindElement(By.ClassName("shopping_cart")).FindElement(By.TagName("a")).Click();
            Utils.DriverUtils.WaitPageLoaded();
        }

    }
}
