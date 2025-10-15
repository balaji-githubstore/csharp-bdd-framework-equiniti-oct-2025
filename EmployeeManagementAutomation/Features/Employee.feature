Feature: Employee
In order to manage the employee records
As an user
I would like to add, edit, delete employee records


Scenario Outline: AddValidEmployeeTest
	Given User have browser with Orange HRM application
	When User enter username as "<username>"
	And User enter password as "<password>"
	And User click on login
	And User click on PIM menu
	And User click on Add Employee menu
	And User fill the employee form
		| firstname | middle_name   | lastname |
		| <fname>   | <middle_name> | <lname>  |
	And User click on save employee
	Then User should get the added profile name "<fname> <lname>"
	And User should verify the firstname field contains "<fname>"
Examples:
	| username | password | fname | middle_name | lname |
	| Admin    | admin123 | john  | w           | wick  |
	| Admin    | admin123 | jack  | w           | ken   |

	
