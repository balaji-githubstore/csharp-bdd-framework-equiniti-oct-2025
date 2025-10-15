using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Hooks
{
    [Binding]
    public class AutomationHooks
    {
        [BeforeScenario]
        public void RunBeforeScenario()
        {
            //browser launch and IPage object
        }

        [AfterScenario]
        public void RunAfterScenario()
        {
            //close the browser
        }
    }
}
