Feature: Registration
	As an intending userof longrichway.com
	I want to register a new account
	So I can buy products


@mytag
Scenario: valid Registration
	Given a user navigate to "https://longrichway.com"
	When a user Clicks on register
	And user enters Firstname "Tade"
	And the user enters Last Name "Toro"
	And the user enters Email Address "aldelt@hotmail.com"
	And user enters Phone "07403554930"
	And user enters Password "p@ssw0rd"
	And user enters Confirm Password "p@ssw0rd"
	And user enters Address "3 miles Lodge"
	And user enters TownCity "London"
	And user enters State "England"
	And the user Clicks on Create Account
	Then the user is logged into New Account