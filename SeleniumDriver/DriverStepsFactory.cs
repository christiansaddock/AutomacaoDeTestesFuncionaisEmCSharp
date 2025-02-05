﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SeleniumDriver
{
    public static class DriverStepsFactory
    {
        public static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        public static IWebDriver driver;

        public static void InitBrowser(string browserName, string modoOculto)
        {
            DirectoryInfo DirProj = new DirectoryInfo(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
            string FullPath = DirProj.Parent.Parent.FullName + "\\..\\..\\SeleniumDriver\\Dependencias";

            switch (browserName.ToUpper())
            {
                case "FIREFOX":
                    driver = new FirefoxDriver(FullPath);
                    Drivers.Add("Firefox", Driver);
                    break;

                case "CHROME":
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.UseSpecCompliantProtocol = true;
                    chromeOptions.BrowserVersion = "latest";
                    chromeOptions.AddArgument("--disable-gpu");
                    chromeOptions.AddArgument("--start-maximized");
                    chromeOptions.AddArgument("--log-level=2");
                    chromeOptions.AddArgument("--mute-audio");
                    if (modoOculto == "SIM")
                    {
                        chromeOptions.AddArguments("--headless");
                        chromeOptions.AddArguments("--window-size=1920x1080");
                    }
                    driver = new ChromeDriver(FullPath, chromeOptions, TimeSpan.FromSeconds(60));

                    Drivers.Add("Chrome", Driver);
                    break;
            }
            if (Driver == null)
                throw new ApplicationException("Driver do Selenium não definido. Não é possível continuar");

            driver.Manage().Window.Position = new System.Drawing.Point(2000, 2);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(10);
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(2);
        }

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                    throw new NullReferenceException("Driver do Selenium não definido. Não é possível continuar");

                return driver;
            }
            set
            {
                driver = value;
            }
        }

        public static void LoadApplication(string url)
        {
            Driver.Url = url;
        }

        public static void CloseAllDrivers()
        {
            foreach (var key in Drivers.Keys)
            {
                Drivers[key].Close();
                Drivers[key].Quit();

                foreach (Process myProc in Process.GetProcessesByName("geckodriver"))
                {
                    myProc.Kill();
                }
                foreach (Process myProc in Process.GetProcessesByName("chromedriver"))
                {
                    myProc.Kill();
                }
            }
        }
    }
}