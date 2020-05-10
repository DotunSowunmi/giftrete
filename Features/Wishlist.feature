Feature: Manage Wishlist
	In order to use Wishlist
	I want to be able to add item to your list

@mytag
Scenario:  Wishlist 
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
