Feature: SampleFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@SmokeTest
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Create a new employee with manadatory details
	#Given I have opened my application
	#Then I should see employee details
	When I fill all the mandatory details in form
	|Name	|Age	|Phone		|Email			|
	|John	|40		|9009009090	|john@gmail.com	|
	|Jane	|80		|8008009090	|jane@gmail.com	|
	|Joe	|20		|8008009090	|joe@gmail.com	|
	#And I click the save button
	#Then I should see all the details saved in my application and DB

Scenario Outline: Create a new employee with manadatory details for different iteration
	#Given I have opened my application
	#Then I should see employee details
	When I fill all the mandatory details in form <Name>, <Age> and <Phone>
	#And I click the save button
	#Then I should see all the details saved in my application and DB
Examples:
	|Name	|Age	|Phone		|
	|John	|40		|9009009090	|
	|Jane	|80		|8008009090	|
	|Joe	|20		|8008009090	|

Scenario: Check if I could get the details entered via Table from Extended Steps
	When I fill all the mandatory details in form
	|Name	|Age	|Phone		|Email			|
	|John	|40		|9009009090	|john@gmail.com	|
	Then I should get the same value from Extended Steps



