Feature: About
	In order to know more useful information about site
	As a user
	I want to have link About 

Background:
	Given The site is open in the Google Chrome

Scenario: Go to About page
	When I click About
	Then the information should be on the screen