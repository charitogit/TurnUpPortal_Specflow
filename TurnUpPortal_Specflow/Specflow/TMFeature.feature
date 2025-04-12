Feature: TMFeature

As a TurnupPortal admin user
I would like to create,update and delete time &  material records
so I can manage Employee's time & material records successfully 

@Regression
Scenario: create time record with valid data
	Given I logged on to TurnUp successfully
	When I navigate to Time & Material tab
	When I create time & material record 
	Then time & material records should be saved successfully 

Scenario Outline: update time & material record with valid data
	Given I logged on to TurnUp successfully
	When I navigate to Time & Material tab
	When I edit the '<Code>' and '<Description>' of existing record
	Then record should be updated with new '<Code>' and '<Description>'

	Examples: 
	| Code       | Description |
	| April2025  | Description1|
	| May2025    | Description2|
	| Jun2025    | Description3|



