Feature: Feedback
	In order to quickly leave feedback
	As a user
	I want to have feedback form

Background:
	Given The site is open in the Google Chrome

Scenario Outline: Filling fields with valid data
	When I click Feedback
	When I entered <data> to the message field
	When I entered test@i.ua to the email field
	When I click Send feedback button
	Then the sucsess  send message should be on the screen

	Examples:
		| data       |
		| abyz       |
		| абюя       |
		| ABYZ       |
		| АБЮЯ       |
		| 1234567890 |
		| !-?.,"'()  |
		| `@#%^&*/<> |

Scenario Outline: Filling email fiald with invalid data
	When I entered <data> to the email field
	When I click Send feedback button
	Then the error message should be on the screen

	Examples:
		| data     |
		| abyz.com |
		| абюя.ua  |
		| ABYZ@com |
		| АБЮЯ @ua |

Scenario: Leaving empty fields
	When I click Feedback
	When I click Send feedback button
	Then the error message should be on the screen