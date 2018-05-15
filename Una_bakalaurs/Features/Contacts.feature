Feature: Contacts

Scenario: Check Contacts page
	Given I am on home page
	When I navigate to Contacts page
	Then I see Contacts welcome message "Labdien!"

Scenario: Check Contacts name field validation
	Given I am on home page
	When I navigate to Contacts page
	And I clik on Contacts form button "Nosūtīt"
	Then I see validation message for Name field "Šo lauku nepieciešams aizpildīt."

Scenario Outline: Validate contacts on Cotacts page
	Given I am on home page
	When I navigate to Contacts page
	Then I see Address <element> "<value>"

	Examples: 
	| element | value                     |
	| tile    | ADRESE:                   |
	| street  | Gustava Zemgala gatve 12, |
	| city    | Rīga, LV-1084,            |
	| country | Latvija                   |
	
Scenario Outline: Check validation messages
	Given I am on home page
	When I navigate to Contacts page
	And I add invalid text "<inputText>" for <field> field
	And I clik on Contacts form button "Nosūtīt"
	Then I see validation message for <field> field "<errorMessage>"
	
	Examples: 
	| field | inputText    | errorMessage                           |
	| Email | invaliEmail  | The e-mail address entered is invalid. |
	| Phone | invalidPhone | The telephone number is invalid.       |
	| Name  |              | Šo lauku nepieciešams aizpildīt.       |

Scenario: Validate error message for email filed
	Given I am on home page
	When I navigate to Contacts page
	And I enter "Tests" in email field
	And I clik on Contacts form button "Nosūtīt"
	Then I see validation message "Vienā vai vairākos laukos ir kļūda. Lūdzu pārbaudiet un mēģiniet vēlreiz."

Scenario: Check form fiels decriptions
	Given I am on home page
	When I navigate to Contacts page
	Then I see Name field decription "Vārds (nepieciešams)"
	And I see email field description "E-pasts (nepieciešams)"
	And I see phone field description "Telefona nr. (nepieciešams)"
	And I see thema field description "Tēma"
	And I see message field description "Ziņa mums"
	
	