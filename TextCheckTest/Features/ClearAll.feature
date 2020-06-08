Feature: ClearAll
	In order to start enter another data 
	As a user
	I want to be able to clear all fields at once
Background:
	Given The site is open in the Google Chrome
Scenario: Clear all fields after adding text
	
	When I write 123 in the first field
	
	When I write 123 in the second field
	When I click ClearAll button
	When I click Compare button
	Then the Empty message should be on the screen