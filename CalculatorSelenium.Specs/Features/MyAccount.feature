Feature: MyAccount

Background: User can login and go to home page
	Given User will go to bikroy home page
	And user go to login form
	When user fill the login form
	Then user will login to bikroy web

Scenario: user can verify all the tabs from My Account section
  When User can go to My Account page
  And user will visit all the tab and verify
  Then User go back to home page

Scenario: user can verify all the tabs from Jobs section
  When User can go to My Account page
  And user will visit and verify all tab from job section
  Then User go back to home page
	