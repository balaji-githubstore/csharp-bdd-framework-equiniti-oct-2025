using EmployeeManagementAutomation.Hooks;
using Io.Cucumber.Messages.Types;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    public class LoginPage
    {

        private AutomationHooks _hooks;
        public LoginPage(AutomationHooks hooks)
        {
            _hooks=hooks;
        }


        public async Task NavigateToUrl()
        {
            await _hooks.PageInstance.GotoAsync("https://opensource-demo.orangehrmlive.com/", 
                new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });
        }

        public async Task EnterUsername(string username)
        {
            await _hooks.PageInstance.Locator("xpath=//input[@name='username']").FillAsync(username);
        }

        public async Task EnterPassword(string password)
        {
            await _hooks.PageInstance.Locator("xpath=//input[@name='password']").FillAsync(password);
        }

        //ClickOnLogin


        //GetInvalidErrorMessage

    }
}
