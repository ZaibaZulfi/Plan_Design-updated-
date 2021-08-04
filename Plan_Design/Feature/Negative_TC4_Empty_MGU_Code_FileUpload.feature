Feature: Negative_TC4_Empty_MGU_Code_FileUpload
	

@mytag
Scenario: Performing file upload operation without Entering MGU Code
	Given User Should be on Home Page -as Display LabeL "Dashboard" 
	When User Clicks Search Button
	Then The List of Search item Will Appear
	When User Clicks Link- Document Search
	Then User Should be on document search page -as display label Document Search.
	When User Clicks Link MGU File Upload.
	Then User Should be on file upload Page.
	When User Clicks Link Upload the File 
	Then User Will Redirect to the Folder from which file is to be upload
	And user Select the file with Different Name and upload
	When User Clicks to Submit the file for Processing
	#Then User Should not get the Successfully File uploaded pop up
	#When User Clicks on pop up Message
	#Then User Should be Again on File upload page
