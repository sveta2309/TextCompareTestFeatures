Feature: SwitchText
	In order to switch texts from one field to another
	As a user
	I want to have Switch button

Background:
	Given The site is open in the Google Chrome
Scenario: Switch texts
	
	When I write 123 in the first field
	When I write 1234 in the second field
	When I click Switch button
	Then field_1 must contain 1234 and field_2 must contain 123
