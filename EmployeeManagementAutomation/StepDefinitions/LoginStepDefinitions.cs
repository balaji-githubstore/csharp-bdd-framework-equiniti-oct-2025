using System;
using Reqnroll;

namespace EmployeeManagementAutomation.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {


        [Given("User have browser with Orange HRM application")]
        [Given("I have browser with Orange HRM application")]
        public void GivenIHaveBrowserWithOrangeHRMApplication()
        {
            Console.WriteLine("given");
        }

        [When("User enter username as {string}")]
        [When("I enter username as {string}")]
        public void WhenIEnterUsernameAs(string username)
        {
            Console.WriteLine("when"+username);
        }

        [When("User enter password as {string}")]
        [When("I enter password as {string}")]
        public void WhenIEnterPasswordAs(string password="Welcome123")
        {
            Console.WriteLine(password);
        }


        [When("User click on login")]
        [When("I click on login")]
        public void WhenIClickOnLogin()
        {
            Console.WriteLine("login");
        }


        [Then("I should access to portal with header as {string}")]
        public void ThenIShouldAccessToPortalWithHeaderAs(string expectedValue)
        {
            Console.WriteLine(expectedValue);
        }

        [Then("I should not get access with error {string}")]
        public void ThenIShouldNotGetAccessWithError(string expectedError)
        {
            Console.WriteLine(expectedError);
        }

    }

}
