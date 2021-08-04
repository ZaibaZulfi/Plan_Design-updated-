Feature: Positive_TC1_MGU_File_Upload
	

@mytag
Scenario: Performing file upload operation 
	Given User Should be on Home Page-as display label "Dashboard" 
	When User clicks search button
	Then The list of search item will appear
	When User Clicks Link Document search
	Then User should be on document search page-as display label Document Search
	When User Clicks link MGU File upload
	Then User should be on file upload page
	And  User Enters MGU Code 
	When User Clicks link upload the file 
	Then User will redirect to the folder from which file is to be upload
	And User Select the file and upload
	When User clicks to submit the file for processing
	Then User should get the successfully file uploaded pop up
	When User clicks on pop up message
	Then User should be again on file upload page