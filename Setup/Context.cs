﻿using System;
using OpenQA.Selenium;
using BoDi;
using CourseManagementTestAutomation.BrowserFactories;

namespace CourseManagementTestAutomation.Setup
{
    public class Context
    {
        ChromeBrowserFactory _chromeBrowserFactory;
        FirefoxBrowserFactory _firefoxBrowserFactory;
        InternetExplorerBrowserFactory _internetExplorerBrowserFactory;
        private readonly IObjectContainer objectContainer;
        private IWebDriver driver;
        // string baseUrl = "http://localhost/CourseManagementSystem/";
        string baseUrl = "https://sorted.com/";
        string browser = "chrome";
      //   string baseUrl = EnvironmentData.baseUrl;
      //  string browser = EnvironmentData.browser;

        public Context(IObjectContainer objectContainer
                      , ChromeBrowserFactory chromeBrowserFactory
                      , FirefoxBrowserFactory firefoxBrowserFactory
                      , InternetExplorerBrowserFactory internetExplorerBrowserFactory)
        {
            this.objectContainer = objectContainer;
            _firefoxBrowserFactory = firefoxBrowserFactory;
            _chromeBrowserFactory = chromeBrowserFactory;
            _internetExplorerBrowserFactory = internetExplorerBrowserFactory;
        }

        public void LoadCMSApplication()
        {
            switch (browser.ToLower())
            {
                case "firefox":
                    driver = _firefoxBrowserFactory.Create(objectContainer);
                    break;

                case "chrome":
                    driver = _chromeBrowserFactory.Create(objectContainer);
                    break;

                case "ie":
                    driver = _internetExplorerBrowserFactory.Create(objectContainer);
                    break;

                default:
                    driver = _chromeBrowserFactory.Create(objectContainer);
                    break;
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Navigate().GoToUrl(baseUrl);
        }

        public void ShutDownCMSApplication()
        {
            driver?.Quit();
        }

        public void TakeScreenshotAtThePointOfTestFailure(string directory, string scenarioName)
        {
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            string path = directory + scenarioName + DateTime.Now.ToString("yyyy-MM-dd") + ".png";
            string Screenshot = screenshot.AsBase64EncodedString;
            byte[] screenshotAsByteArray = screenshot.AsByteArray;
           // screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
        }
    }
}
