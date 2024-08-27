using System;
using TechTalk.SpecFlow;
using CourseManagementTestAutomation.Pages;
using NUnit.Framework;

namespace CourseManagementTestAutomation.StepDefinitions
{
    [Binding]
    public class StudentStepDefinitions
    {
        HomePage _homePage;
        StudentPage _studentPage;
        StudentFormPage _studentFormPage;

        public StudentStepDefinitions(HomePage homePage, StudentPage studentPage, StudentFormPage studentFormPage)
        {
            _homePage = homePage;
            _studentPage = studentPage;
            _studentFormPage = studentFormPage;
        }



        [When(@"a user clicks on students link")]
        public void WhenAUserClicksOnStudentsLink()
        {
          _homePage.ClickOnStudentLink();
        }

        [When(@"a user click on create new link")]
        public void WhenAUserClickOnCreateNewLink()
        {
           _studentPage.ClickOnNewFormLink();
        }

        [When(@"a user fills-in FamilyName field with (.*)")]
        public void WhenAUserFills_InFamilyNameFieldWithEric(string familyName)
        {
            _studentFormPage.FillInFamilyName(familyName);
        }

        [When(@"a user fills-in FirstName field with (.*)")]
        public void WhenAUserFills_InFirstNameFieldWithTadar(string firstName)
        {
           _studentFormPage.FillInFirstName(firstName);
        }

        [When(@"a user fills-in EnrollmentDate field with (.*)")]
        public void WhenAUserFills_InEnrollmentDateFieldWith(string enrollmentDate)
        {
           _studentFormPage.FillInEnronmentDate(enrollmentDate);
        }

        [When(@"a user clicks on create button")]
        public void WhenAUserClicksOnCreateButton()
        {
          _studentFormPage.ClickOnCreateButton();
        }

        [Then(@"a new student record (.*) must be created")]
        public void ThenANewStudentRecordEricMustBeCreated(string firstName)
        {
            string expectedUrl = "https://sorted.com/";
            string actualUrl =  _studentPage.GetStudentPageUrl();
            Assert.AreEqual(expectedUrl, actualUrl);
            Assert.IsTrue(expectedUrl.Equals(actualUrl));
        }

        [When(@"a user fills-in new student record form page with the data below")]
        public void WhenAUserFills_InNewStudentRecordFormPageWithTheDataBelow(Table table)
        {
         
        }
    }
}
