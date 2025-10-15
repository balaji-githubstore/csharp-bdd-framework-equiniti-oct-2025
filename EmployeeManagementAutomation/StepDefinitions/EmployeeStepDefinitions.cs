using System;
using EmployeeManagementAutomation.Hooks;
using Reqnroll;

namespace EmployeeManagementAutomation.StepDefinitions
{
    [Binding]
    public class EmployeeStepDefinitions 
    {
        [When("User click on PIM menu")]
        public void WhenUserClickOnPIMMenu()
        {
            
        }

        [When("User click on Add Employee menu")]
        public void WhenUserClickOnAddEmployeeMenu()
        {
            
        }

        [When("User fill the employee form")]
        public void WhenUserFillTheEmployeeForm(DataTable dataTable)
        {
            //Console.WriteLine(dataTable.Rows[0][0]);
            //Console.WriteLine(dataTable.Rows[0][1]);

            Console.WriteLine(dataTable.Rows[0]["firstname"]);
            Console.WriteLine(dataTable.Rows[0]["middle_name"]);
            Console.WriteLine(dataTable.Rows[0]["lastname"]);

        }

        [When("User click on save employee")]
        public void WhenUserClickOnSaveEmployee()
        {
            
        }

        [Then("User should get the added profile name {string}")]
        public void ThenUserShouldGetTheAddedProfileName(string expectedProfileName)
        {
            Console.WriteLine(expectedProfileName);
        }

        [Then("User should verify the firstname field contains {string}")]
        public void ThenUserShouldVerifyTheFirstnameFieldContains(string expectedFirstName)
        {
            Console.WriteLine(expectedFirstName);
        }
    }
}
