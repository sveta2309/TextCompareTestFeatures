Feature: EditText
	In order to edit text for better comparing
	As a user
	I want to have automated editing options

Background:
	Given The site is open in the Google Chrome

Scenario: Deleting extra spaces
	When I write 123 in the first field
	When I press Space in the field_1
	When I write 123 in the second field
	When I click Edit text
	When I click Remove excess white space
	When I click Compare button
	Then the Identical message should be on the screen

Scenario: Make all symbols lowercase
	When I write Q in the first field
	When I write q in the second field
	When I click Edit text
	When I click To lowercase
	When I click Compare button
	Then the Identical message should be on the screen

Scenario: Replace line breaks with space
	When I write Q in the first field
	When I press Enter in the field_1
	When I write Q in the first field
	When I write Q in the second field
	When I press Space in the field_1
	When I write Q in the second field
	When I click Edit text
	When I click Replace line breaks with spaces
	When I click Compare button
	Then the Identical message should be on the screen