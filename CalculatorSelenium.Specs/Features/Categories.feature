Feature: Categories

Background: User can login and go to home page
	Given User will go to bikroy home page
	And user go to login form
	When user fill the login form
	Then user will login to bikroy web

Scenario: user will verify all categories page
	When User go to any page from categories 
	And verify that page
	Then User go back to home page