using System;
using TechTalk.SpecFlow;
using CourseManagementTestAutomation.Setup;

namespace CourseManagementTestAutomation.StepDefinitions
{
    [Binding]
    public class CommonStepsDefinitions
    {
        Context _context;

        public CommonStepsDefinitions(Context context)
        {
            _context = context;
        }
        [Given(@"that the CMS application is loaded")]
        public void GivenThatTheCMSApplicationIsLoaded()
        {
           _context.LoadCMSApplication();
        }

        [AfterScenario]
        public void CloseApplicationUnderTest()
        {
            _context.ShutDownCMSApplication();
        }
    }
}
