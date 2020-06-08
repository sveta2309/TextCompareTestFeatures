Feature: CompareText
	In order to know are this texts equal or not
	As a user
	I want to compare texts

Background:
	Given The site is open in the Google Chrome
Scenario: Compare two equal texts
	When I write 123 in the first field
	When I write 123 in the second field
	When I click Compare button
	Then the Identical message should be on the screen

Scenario: Compare two not equal texts
	When I write 123 in the first field
	When I write 1234 in the second field
	When I click Compare button
	Then two fields with differencies should be on the screen

Scenario: Compare empty fields
	When I clicked field_1
	When I clicked field_2
	When I click Compare button
	Then the Empty message should be on the screen