@regression
Feature: Login
In order to manage the employee records
As an user
I want to login to the dashboard

 @valid
Scenario: ValidLoginTest
	Given I have browser with Orange HRM application
	When I enter username as "Admin"
	And I enter password as "admin123"
	And I click on login
	Then I should access to portal with header as "Time at Work"

	@invalid @smoke 
Scenario Outline: InvalidLoginTest
	Given I have browser with Orange HRM application
	When I enter username as "<username>"
	And I enter password as "<password>"
	And I click on login
	Then I should not get access with error "<expected_error>"
Examples:
	| username | password | expected_error      |
	| john     | john123  | Invalid credentials |
	| saul     | saul123  | Invalid credentials |


Scenario: ValidLoginTest3
	#Given I have browser with Orange HRM application
	When I Feed data from excel "testdata/orange-test-data.xlsx" with sheet as "InvalidLoginTest" 
