Feature: HomePage
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Chrome
Scenario: Home page title
	Given I am on home page
	Then I see Home page open 
	
Scenario Outline: Validate Home page secondary title
	Given I am on home page
	When I see HomePage second title "10 IEMESLI PAR LABU ERLAU ĀRA APRĪKOJUMA IZVĒLEI"
	Then I see "10" reasons to use Erlau production
	And I see the <element_number> reason is "<value>"

	Examples: 
	| element_number | value                                                   |
	| first          | Moduļu sistēma,Iespēja kombinēt pamata un sēdekļa daļas |
	| second         | Mitrumizturība                                          |
	| third          | Noturība pret bojājumiem                                |
	| fourth         | Izturība pret koroziju                                  |
	| fifth          | Anti-graffiti pārklājums                                |
	| sixth          | Ilgtermiņa kalpošana                                    |
	| seventh        | Vienkārša kopšana                                       |
	| eighth         | Izmaksu efektivitāte                                    |
	| ninth          | Vienkārša montāža                                       |
	| tenth          | Izstrādājumu stabilitāte                                |

Scenario: Check Home Page footer
	Given I am on home page
	When I see HomePage second title "10 IEMESLI PAR LABU ERLAU ĀRA APRĪKOJUMA IZVĒLEI"
	Then I see Home Page footer title "Jums palīdzēs profesionālā komanda!"

Scenario: Check Home Page footer href
	Given I am on home page
	When I see HomePage second title "10 IEMESLI PAR LABU ERLAU ĀRA APRĪKOJUMA IZVĒLEI"
	And I click on footer href "UZZINI VAIRĀK PAR MUMS»"
	Then I see Contacts welcome message "Labdien!"

Scenario Outline: Validate all Home Page footer hrefs
	Given I am on home page
	When I click on Home Page footer href "<href>"
	Then I see "<href>" page with tile "<title>" 

	Examples: 
	| href                                   | title                                    |
	| MŪSU PRODUKCIJA                        | MŪSU PRODUKCIJA                          |
	| Soliņi                                 | SOLI                                     |
	| Solu sistēmas                          | SOLU SISTĒMAS                            |
	| Solu/galdu kombinācijas                | SOLU / GALDU KOMBINĀCIJAS                |
	| Galdi                                  | GALDI                                    |
	| Krēsli/sauļošanās krēsli               | KRĒSLI / SAUĻOŠANĀS KRĒSLI               |
	| Atkritumu konteineri/konteineri augiem | ATKRITUMU KONTEINERI / KONTEINERI AUGIEM |
	| Velosipēdu novietnes/norobežojumi      | NOROBEŽOJUMI / VELISOPĒDU NOVIETNES      |
	| Aprīkojums fitnesam                    | APRĪKOJUMS FITNESAM                      |
	| KONFIGURATORS                          | KONFIGURATORS                            |
	| Konfigurators – solu sistēma           | Konfigurators solu sistēmas              |
	| Konfigurators – galdu sistēma          |                                          |
	| Konfigurators – sols                   |                                          |
	| REALIZĒTIE PROJEKTI                    | REALIZĒTIE PROJEKTI                      |
	| Terms of use                           | Terms Of Use                             |
	
Scenario: Check Home page navigation bar elements
	Given I am on home page
	Then I see navigation elements are "MŪSU PRODUKCIJA", "KONFIGURATORS", "REALIZĒTIE PROJEKTI", "GALERIJA", "KONTAKTI"
