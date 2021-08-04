Feature: Negative_TC1_Wrong_MGU_Code
	

@mytag
Scenario: Performing file upload operation with wrong MGU code
	Given user Should be on home page-as display label "Dashboard" 
	When user clicks search button
	Then the list of search item will appear
	When user Clicks link Document search
	Then user should be on document search page-as display label Document Search
	When user Clicks link MGU File upload
	Then user should be on file upload page
	And  user Enters Wrong MGU Code 
	When User clicks link upload the file 
	Then user will redirect to the folder from which file is to be upload
	And user Select the file and upload
	When user clicks to submit the file for processing
	Then user should not get the successfully file uploaded pop up
	When user clicks on pop up message
	Then user should be again on file upload page
 