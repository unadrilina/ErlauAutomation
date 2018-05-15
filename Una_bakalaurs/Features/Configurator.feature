Feature: Configurator

@mytag
Scenario: Check Configurator page
	Given I am on home page
	When I navigate to Cofigurator page
	Then I see Configurator title "KONFIGURATORS"

Scenario: Validate konfigurator options
	Given I am on home page
	When I navigate to Cofigurator page
	Then I see Configurator title "KONFIGURATORS"
	And I see "3" configuratio options

Scenario Outline: Validate Configurator all options 
	Given I am on home page
	When I navigate to Cofigurator page
	And I select "<selectedIteam>" option
	Then I see selected configurator Title "<title>"

	Examples: 
	| selectedIteam | title                             |
	| SOLS          | KONFIGURATORS - SOLS              |
	| SOLU SISTĒMA  | Konfigurators solu sistēmas       |
	| SOLU/GALDU K  | Konfigurators solu/galdu sistēmas |
	
Scenario: Check seconadry title in Configurator page
	Given I am on home page
	When I navigate to Cofigurator page
	Then I see Configurator page secondary title "Ar ERLAU konfiguratora palīdzību Jūs varat veidot individuāla dizaina solus, solu sistēmas un galdus. Vienkārši klikšķinot, varat izvēlēties pamatadaļu, sēdvietu un galda daļu detaļas, to krāsas un izmērus."


