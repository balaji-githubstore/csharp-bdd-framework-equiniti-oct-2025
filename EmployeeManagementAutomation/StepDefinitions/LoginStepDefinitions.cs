using System;
using System.Threading.Tasks;
using EmployeeManagementAutomation.Hooks;
using Microsoft.Playwright;
using Reqnroll;

namespace EmployeeManagementAutomation.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {

        [Given("User have browser with Orange HRM application")]
        [Given("I have browser with Orange HRM application")]
        public async Task GivenIHaveBrowserWithOrangeHRMApplicationAsync()
        {
            await AutomationHooks.PageInstance.GotoAsync("https://opensource-demo.orangehrmlive.com/", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });
        }


        [When("User enter username as {string}")]
        [When("I enter username as {string}")]
        public async Task WhenIEnterUsernameAs(string username)
        {
            await AutomationHooks.PageInstance.Locator("xpath=//input[@name='username']").FillAsync(username);
        }

        [When("User enter password as {string}")]
        [When("I enter password as {string}")]
        public void WhenIEnterPasswordAs(string password)
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
