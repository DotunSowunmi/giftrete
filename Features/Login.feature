Feature: Login
	As a registered user, I want to login into Giftrete website 
    So that I can use the website

@mytag
Scenario: Valid User Login to Giftrete website
   Given I navigate to giftrete
	And I click on sign in
	When  I enter my registered email address
	And  I enter my registered password 
	And I click on sign in button
	Then I should be signed in
   Then my user homepage should be displayed 



Scenario: Login with invalid UserDetails
   Given I navigate to giftrete
	And I click on sign in 
	When  I enter my registered email address
	And  I enter my invalid password 
	And I click on sign in button
   Then the message "Your login credentials are invalid. Please try again" should be displayed 