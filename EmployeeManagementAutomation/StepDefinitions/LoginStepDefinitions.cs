using EmployeeManagementAutomation.Hooks;
using EmployeeManagementAutomation.Pages;
using Io.Cucumber.Messages.Types;
using Microsoft.Playwright;
using NUnit.Framework;
using Reqnroll;
using System;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {

        private LoginPage _loginPage;
        public LoginStepDefinitions(LoginPage loginPage)
        {
           _loginPage = loginPage;
        }

        [Given("User have browser with Orange HRM application")]
        [Given("I have browser with Orange HRM application")]
        public async Task GivenIHaveBrowserWithOrangeHRMApplicationAsync()
        {
            await _loginPage.NavigateToUrl();
        }


        [When("User enter username as {string}")]
        [When("I enter username as {string}")]
        public async Task WhenIEnterUsernameAs(string username)
        {
           await _loginPage.EnterUsername(username);
        }

        [When("User enter password as {string}")]
        [When("I enter password as {string}")]
        public async Task WhenIEnterPasswordAs(string password)
        {
            await _loginPage.EnterPassword(password);
        }


        [When("User click on login")]
        [When("I click on login")]
        public async Task WhenIClickOnLogin()
        {
            await _loginPage.ClickOnLogin();
        }


        [Then("I should access to portal with header as {string}")]
        public void ThenIShouldAccessToPortalWithHeaderAs(string expectedValue)
        {
            Console.WriteLine(expectedValue);
        }

        [Then("I should not get access with error {string}")]
        public async Task ThenIShouldNotGetAccessWithError(string expectedError)
        {
            string actualError =await _loginPage.GetInvalidErrorString();
            Assert.That(actualError, Is.EqualTo(expectedError));
        }

    }

}
