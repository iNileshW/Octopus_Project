Feature: People page functionality 
	In order to validate people page 
	As a tester 
	I want to check the search functionality of people

	@SmokeTest
	Scenario Outline: People page search functionality validation with invalid data (-ve Case)
	Given I am on Octopus Investments Poeple page of website
	When I search <keyword> 
	Then I am presented with No result displayed
	
	Examples: 
	| keyword |
	| dsfklds |
	| asdhjjk |

	@RegressionTest
	Scenario Outline: People page search functionality validation with valid data (+ve Case)
	Given I am on Octopus Investments Poeple page of website
	When I search <Name> 
	Then I am presented with Result matching the test data
	Examples: 
	| Name  |
	| Adam  |
	| David |
	| John  |
	| Mike  |
	| James |


	@RegressionTest
	Scenario Outline: Team Selection validation 
	Given I am on Octopus Investments Poeple page of website
	When I  select a checkbox as per test data to select <Team>
	Then I am presented with Result matching the test data
	Examples:
	| Team                       |
	| Business Development team  |
	| Client Relations team      |
	| Corporate Development team |
	| Energy team                |
	| Institutional Funds team   |
	| Intermediate Capital team  |
	| Multi Manager team         |

	Scenario: Descending order display validation
	Given I am on Octopus Investments Poeple page of website
	When I select descending sort in drop down
	Then I am presented with results in descending order

	Scenario: Validation of members page displayed
	Given I am on Octopus Investments Poeple page of website
	When I click on image of member
	Then I am presented with members page giving information

	Scenario: Validation of Displaying page in larger Font 
	Given I am on Octopus Investments Poeple page of website
	When I click on enlarge font 
	Then the page is displayed with bigger font

	Scenario: Validation of Displaying page in Smaller Font 
	Given I am on Octopus Investments Poeple page of website
	When I click on reduce font size
	Then the page is displayed with smaller size font

	Scenario: Validation of Team Display for two teams
	Given I am on Octopus Investments Poeple page of website
	When I select two checkboxes of teams
	Then I am presented with members of those two team

	Scenario: Validation of connetion link image 
	Given I am on Octopus Investments Poeple page of website
	When I click on Making the connection link
	Then I am presented with Octopus Investments Poeple page of website

	Scenario: Website Search functionality validation with invalid data
	Given I am on Octopus Investments Poeple page of website
	When I enter invalid data in search box of website
	Then the page is displayed with no results found