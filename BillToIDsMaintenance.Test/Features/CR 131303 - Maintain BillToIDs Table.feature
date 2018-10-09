@CR 131303 @BillToID @IBM MSC Outbound Routing

Feature: CR 131303 - Maintain BillToIDs Table
	IBM MSC Outbound Routing - create tool in Strategic EDI tool so that we can modify the table for CR 131302 at any time by adding and removing bill to IDs
	In order to maintain BillToIDs table in UnitedStationers DB
	As an operator
	I want to have a functionality to add or delete BillToID in BillToIDs table

Scenario: Get BillToIDs
	When User does not provide any Keyword to search BillToID
	Then It should return all the BillToIDs

Scenario Outline: Search BillToIDs
	When User use <Keyword> to search BillToID
	Then It should return the <ExpectedRecords> records containing the keyword

	Examples: 
	| Keyword | ExpectedRecords |
	| ABC     | 3               |
	| 987     | 1               |
	| ****    | 0               |

Scenario Outline: Creat a New BillToID
	When User tries to create a <BillToID>
		And There is no matched <BillToID> in DB
	Then The <BillToID> should be created and stored in BillToIDs table

	Examples: 
	| BillToID |
	| 987654   |
	| NewID    |

Scenario Outline: Try to Create an existing BillToID
	When User tries to create a <BillToID>
		And There is a matched <BillToID> in DB
	Then The <BillToID> should not be created and stored in BillToIDs table
	
	Examples: 
	| BillToID |
	| 123456   |
	| ABCEDF   |

Scenario Outline: Delete an existing BillToID
	Given There is an existing <BillToID> in BillToID table
	When User tries to delete <BillToID>
	Then <BillToID> should be deleted from BillToID table

	Examples: 
	| BillToID |
	| 123456   |
	| ABCEDF   |