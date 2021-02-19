Feature: SpecFlowFeature1
	Simple calculator

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

	Scenario: Subtract two numbers
	Given the first number is 70
	And the second number is 50
	When the two numbers are subtracted
	Then the result should be 20

	Scenario: Multiply two numbers
	Given the first number is 5
	And the second number is 6
	When the two numbers are multiplied
	Then the result should be 30

	Scenario: Divide two numbers
	Given the first number is 50
	And the second number is 5
	When the two numbers are dubtracted
	Then the result should be 10
