Feature: OurProduction
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Check OurProducion page image 
	Given I am on home page
	When I navigate to OurProduction page
	Then I see "8" image are present on OurProduction page

Scenario Outline: Check OurProduction list
	Given I am on home page
	When I navigate to OurProduction page
	Then I see the <element> OurProduction element is "<value>"
	
	Examples: 
	| element | value                                  |
	| first   | SOLI                                   |
	| second  | SOLU SISTĒMAS                          |
	| third   | SOLU/GALDU KOMBINĀCIJAS                |
	| fourth  | GALDI                                  |
	| fifth   | KRĒSLI/SAUĻOŠANĀS KRĒSLI               |
	| sixth   | ATKRITUMU KONTEINERI/KONTEINERI AUGIEM |
	| seventh | VELOSIPĒDU NOVIETNES/NOROBEŽOJUMI      |
	| eighth  | APRĪKOJUMS FITNESAM                    |
	