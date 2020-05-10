Feature: Registration
	In order to use Giftrete website
	I should be able to register

@mytag
Scenario: Registration on Giftrete website
	Given I navigate to giftrete
	When I click on Create Account 
	 And I enter First Name
	 And I enter Last Name
	 And I enter email address
	 And I click country code
	 And I select United Kingdom
	 And I enter Phone Number
     And I enter Password 
	 And I enter confirm password 
	 And I click on Register button
	#Then the message "Thank you for signining up, you may now login" should be displayed
	Then I should be registered 
	

Scenario: Invalid Registration on Giftrete website
	Given I navigate to giftrete
	When I click on Create Account 
	 And I enter First Name
	 And I enter Last Name
	 And I enter email address
	 And I click country code
	 And I select United Kingdom
	 And I enter Phone Number
     And I enter Password 
	 And I enter wrong confirm password 
	 And I click on Register button
    #Then error message "The confirm Password field does not match the Password field" should be displayed