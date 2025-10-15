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
	# click pim-->add employee --> add fname, mname,lastname and save 
	
