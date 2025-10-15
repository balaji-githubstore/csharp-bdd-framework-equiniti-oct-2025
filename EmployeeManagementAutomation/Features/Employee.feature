Feature: Employee
In order to manage the employee records
As an user
I would like to add, edit, delete employee records


Scenario: AddValidEmployeeTest
	Given User have browser with Orange HRM application
	When User enter username as "Admin"
	And User enter password as "admin123"
	And User click on login
	And User click on PIM menu
	And User click on Add Employee menu
	And User fill the employee form
		| firstname | middle_name | lastname |
		| jack      | w           | wick     |
	And User click on save employee
	Then User should get the added profile name "jack wick"
	And User should verify the firstname field contains "jack"

	
