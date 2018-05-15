Feature: RealizedProjects
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Check Realized project page
	Given I am on home page
	When I navigate to Projects page
	Then I see Projects welcome message "REALIZĒTIE PROJEKTI"
	And I see Projects page secondary Title "Erlau produkcijas kvalitāti pazīst jau visā pasaulē!"
	And I see Project thirth Title "Eiropā un pasaulē lielākie realizētie projekti."

Scenario: Verifie Projets quality reasons
	Given I am on home page
	When I navigate to Projects page
	Then I see Projects welcome message "REALIZĒTIE PROJEKTI"
	And I see "6" Project quality reasosn

Scenario Outline: Check Project quality resaons titles
	Given I am on home page
	When I navigate to Projects page
	Then I see Projects welcome message "REALIZĒTIE PROJEKTI"
	And I see the <reasonNumber> Projects quality reason is "<value>"
	
	Examples: 
	| reasonNumber | value                                                                     |
	| firts        | Šveices dzelzceļš, sols Quadri Style                                      |
	| second       | Metro Kanādā (Metrolinx), sēdvietas Vari Topsit                           |
	| third        | Automagistrāle A8, Burgau Atpūtas zona, solu/galdu kombinācija Parador    |
	| fourth       | Manheimas Ebreju kapi, sols Stella Style                                  |
	| fifth        | Āra baseins Ostalbkreisā, sauļošanās krēsli Marina ar saslēgšanas sistēmu |
	| sixth        | Daudzīvokļu māja Štutgardē, soli Siena Harmony                            |

Scenario: Check options for Projects paces
	Given I am on home page
	When I navigate to Projects page
	Then I see  projects are listed for "VĀCIJĀ  AUSTRIJĀ  ŠVEICĒ" and "VISĀ PASAULĒ"

	