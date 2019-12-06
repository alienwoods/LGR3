Feature: PCC
	Test

Background: Open the test site
	Given I Open a Chrome Browser
	And I navigate to http://www.shino.de/parkcalc/index.php

@Dummy @Ignore
Scenario: Open and check home page
	Then the correct page appears

Scenario Outline: Valet Parking
	When I select <pType>
	And I set entry datetime <pEntry>
	And I set leave datetime <pLeave>
	And I press Caluclate
	Then I got the following price and metrics: <rPrice> dollar <rDays> days <rHours> hours <rMinutes> minutes

Examples: 
| pType              | pEntry             | pLeave             | rPrice | rDays | rHours | rMinutes | comment                                         |
| Valet Parking      | 12/1/2019 01:00 AM | 12/1/2019 02:00 AM | 12     | 0     | 1      | 0        |                                                 |
| Valet Parking      | 12/1/2019 01:00 AM | 12/1/2019 05:00 AM | 12     | 0     | 4      | 0        |                                                 |
| Valet Parking      | 12/1/2019 01:00 AM | 12/2/2019 02:00 AM | 36     | 1     | 1      | 0        |                                                 |
| Short-Term Parking | 12/1/2019 01:00 AM | 12/1/2019 02:00 AM | 2      | 0     | 1      | 0        |                                                 |
| Short-Term Parking | 12/1/2019 01:00 AM | 12/2/2019 02:00 AM | 26     | 1     | 1      | 0        |                                                 |
| Valet Parking      | 12/1/2019 00:00 AM | 12/1/2019 24:00 AM | 18     | 1     | 0      | 0        |                                                 |
| Short-Term Parking | 12/1/2019 00:00 AM | 12/2/2019 00:00 AM | 24     | 1     | 0      | 0        |                                                 |
| Short-Term Parking | 12/1/2019 00:00 AM | 12/1/2019 11:59 PM | 24     | 0     | 23     | 59       | 47 dollar, but with daily limit it should be 24 |


