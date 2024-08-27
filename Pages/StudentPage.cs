using CourseManagementTestAutomation.Setup;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementTestAutomation.Pages
{
    public class StudentPage
    {
        IWebDriver _driver;
        public StudentPage(IWebDriver driver)
        {
            _driver = driver;
        }

        By createNewLink = By.XPath("/html/body/div[2]/p/a");
        By studentTable = By.XPath("//table[@class='table']");
        By studentTableRow = By.TagName("tr");
        By editBtn = By.CssSelector("a[href*='Edit']");
        By deleteBtn = By.CssSelector("a[href*='Delete']");

        public StudentFormPage ClickOnNewFormLink()
        {
            _driver.Click(createNewLink);
            return new StudentFormPage(_driver);
        }

        public string GetStudentPageUrl()
        {
            return _driver.GetUrl();
        }
    }
}