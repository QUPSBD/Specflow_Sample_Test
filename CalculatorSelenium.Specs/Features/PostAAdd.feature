Feature: PostAAdd

Background: User can login and go to home page
	Given User will go to bikroy home page
	And user go to login form
	When user fill the login form
	Then user will login to bikroy web

Scenario: user can look something to buy
	Given user can click on post your Ad
	And user can click Look for something to buy
	When user select category and subcategory
	And user select City and Local area
	Then user can fill the details of product

Scenario: user can sell something
	Given user can click on post your Ad
	And user can click sell an Item
	When user select category and subcategory
	And user select City and Local area
	Then user can fill the details of product sell