Feature: FormTest
	In order to validate basic information page
	As a user
	I want to enter data on fields

@mytag
Scenario Outline: Form test
	Given The basic information page is open
	When I enter the name <name>
	And I enter the surname <surname>
	And I enter the email address <email address>
	And I enter the phone number <phone number>
	And I enter the pesel number <pesel>
	And I enter the id number <id number>
	And I enter the date of birth <date of birth>
	And I click Next button
	Then The Consents page is opened

	Examples:
	| description | name | surname  | email address     | phone number | pesel       | id number | date of birth |
	| correctData | Jan  | Kowalski | jankowalski@wp.pl | 600600600    | 46022089926 | AMJ822089 | 20.04.1994    |