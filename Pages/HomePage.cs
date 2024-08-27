using CourseManagementTestAutomation.Setup;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementTestAutomation.Pages
{
    public class HomePage
    {
        IWebDriver _driver;
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        By studentLink = By.XPath("/html/body/div[1]/div/div[2]/ul[1]/li[1]/a");
        //By allModules = By.CssSelector("a[href*='CourseManagementSystem']");
        By allModules = By.XPath("//*[@href]");

        public StudentPage ClickOnStudentLink()
        {
            _driver.Click(studentLink);
            return new StudentPage(_driver);
            //_driver.FindElement(studentLink).Click();

            // _driver.FindElement(studentLink).Clear();
            // _driver.FindElement(studentLink).SendKeys("Kaz");
            // _driver.FindElement(studentLink).SendKeys(Keys.Tab);
            // instead of this four line above

            //_driver.ClearAndSendKeys(studentLink, "");

        }
    }
}
