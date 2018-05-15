Feature: Gallery
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Check Gallery page
	Given I am on home page
	When I navigate to Gallery page
	Then I see Gallery welcome message "SOLU SISTĒMAS"

Scenario: Check Gallery imgae list
	Given I am on home page
	When I navigate to Gallery page
	Then I see Gallery welcome message "SOLU SISTĒMAS"
	And I see "34" image in gallery