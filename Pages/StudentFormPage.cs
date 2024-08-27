using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagementTestAutomation.Setup;

namespace CourseManagementTestAutomation.Pages
{
    public class StudentFormPage
    {
       IWebDriver _driver;
        public StudentFormPage  (IWebDriver driver)
        {
            _driver = driver;
        }

        By familyNameField = By.Id("LastName");
        By firstNameField = By.Id("FirstName");
        By enrollmentDate = By.Id("EnrollmentDate");
        By createSaveAndDeleteBtn = By.CssSelector("input[type='submit']");
        By familyNameErrorMsg = By.CssSelector("[data-valmsg-for=LastName]");
        By firstNameErrorMsg = By.CssSelector("[data-valmsg-for=FirstName]");
        By enrollmentDateErrorMsg = By.CssSelector("[data-valmsg-for=EnrollmentDate]");

        public void FillInFamilyName(string familyNameData) 
        {
            _driver.ClearAndSendKeys(familyNameField, familyNameData);
        }

        public void FillInFirstName(string firstNameData)
        {
            _driver.ClearAndSendKeys(firstNameField, firstNameData);
        }

        public void FillInEnronmentDate(string enrollmentDateData)
        {
       
            _driver.ClearAndSendKeys(enrollmentDate, enrollmentDateData);
        }

        public StudentPage ClickOnCreateButton()
        {
            _driver.Click(createSaveAndDeleteBtn);
            return new StudentPage(_driver);
        } 




    }
}
