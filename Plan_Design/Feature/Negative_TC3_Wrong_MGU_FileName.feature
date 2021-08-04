Feature: Negative_TC3_Wrong_MGU_FileName
	

@mytag
Scenario: Performing file upload operation with wrong MGU File Name
	Given User Should be on Home Page-as Display LabeL "Dashboard" 
	When User Clicks search Button
	Then The List of Search item Will appear
	When User Clicks Link Document Search.
	Then User Should be on document search page-as display label Document Search.
	When User Clicks Link MGU File upload.
	Then User Should be on file upload page.
	And  User Enters MGU-Code 
	When User Clicks Link upload the File 
	Then User Will Redirect to the folder from which file is to be upload
	And user Select the file with different Name and upload
	When User Clicks to submit the file for Processing
	Then User Should not get the Successfully file uploaded pop up
	When User Clicks on pop up message
	Then User Should be Again on file upload page