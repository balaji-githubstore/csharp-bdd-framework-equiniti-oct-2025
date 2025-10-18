using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Hooks
{
    /// <summary>
    /// Browser and Report Configuration done in this class
    /// </summary>
    [Binding]
    public class AutomationHooks
    {
        private IPlaywright PlaywrightInstance { get; set; }
        private IBrowser BrowserInstance { get; set; }
        private IBrowserContext BrowserContextInstance { get; set; }
        public IPage PageInstance { get; set; }


        [BeforeScenario]
        public async Task RunBeforeScenarioAsync()
        {
            PlaywrightInstance = await Playwright.CreateAsync();
            BrowserInstance = await PlaywrightInstance.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            BrowserContextInstance = await BrowserInstance.NewContextAsync();
            PageInstance = await BrowserContextInstance.NewPageAsync();


        }

        [AfterScenario]
        public void RunAfterScenario()
        {
            PlaywrightInstance.Dispose();

        }
    }
}
