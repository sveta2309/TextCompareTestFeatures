Feature: EnterData
	In order to do next actions 
	As a user
	I want to be able to enter data in the fields

Background:
	Given The site is open in the Google Chrome

Scenario Outline: Enter data to the field
	When I enter <data> to the <field>
	Then the <result> in the <field> should be on the screen

	Examples:
		| data       | field | result     |
		| abyz       | 1     | abyz       |
		| абюя       | 1     | абюя       |
		| ABYZ       | 1     | ABYZ       |
		| АБЮЯ       | 1     | АБЮЯ       |
		| 1234567890 | 1     | 1234567890 |
		| !-?.,"'()  | 1     | !-?.,"'()  |
		| `@#%^&*/<> | 1     | `@#%^&*/<> |
		| abyz       | 2     | abyz       |
		| абюя       | 2     | абюя       |
		| ABYZ       | 2     | ABYZ       |
		| АБЮЯ       | 2     | АБЮЯ       |
		| 1234567890 | 2     | 1234567890 |
		| !-?.,"'()  | 2     | !-?.,"'()  |
		| `@#%^&*/<> | 2     | `@#%^&*/<> |

