Feature: EmployeeFeature

As an admin user for TurnUp Portal I would like to 
create , update and delete employee records 
so I can manage employee records successfully 

@Regression 
Scenario Outline: create new employee record
	Given I logged into TurnUp portal successfully
	When I navigate to employee page
	When I create new employee '<Name>' record 
	Then new employee '<Name>' record should be saved successfully

Examples: 
| Name	|
| Peanut   |
| Charito  |


Scenario Outline: update employee record
Given I logged into TurnUp portal successfully
When I navigate to employee page
When  I edit '<Name>','<Username>','<Contact>','<Password>','<Retypepassword>','<Isadmin>'and '<Vehicle>' of employee record
Then the '<Name>','<Username>','<Contact>','<Password>','<Retypepassword>','<Isadmin>'and '<Vehicle>' of employee record should be updated successfully 

Examples: 
| Name    | Username | Contact  | Password  | Retypepassword | Isadmin | Vehicle |  
| Peanut1 | Peanut1  | 12345677 | P@ssw0rd2 | P@ssw0rd2      | True    | Bike    |  



Scenario Outline: delete employee record
Given I logged into TurnUp portal successfully
When I navigate to employee page
When I delete the '<Name>' and '<Username>' employee record
Then '<Name>' and '<Username>' employee record should be deleted successfully 

Examples: 
| Name    | Username |
| Peanut1 | Peanut1  |
