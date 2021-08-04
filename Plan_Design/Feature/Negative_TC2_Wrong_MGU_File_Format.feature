Feature: Negative_TC2_Wrong_MGU_File_Format
	

@mytag
Scenario: Performing file upload operation with wrong MGU File Format
	Given User Should be on Home Page-as Display Label "Dashboard" 
	When User Clicks search button
	Then The List of Search item will appear
	When User Clicks Link Document Search
	Then User Should be on document search page-as display label Document Search
	When User Clicks Link MGU File upload
	Then User Should be on file upload page
	And  User Enters MGU- Code 
	When User Clicks Link upload the file 
	Then User Will redirect to the folder from which file is to be upload
	And user Select the Wrong file format and upload
	When User Clicks to submit the file for processing
	Then User Should not get the successfully file uploaded pop up
	When User ClickS on pop up message
	Then User Should be again on file upload page