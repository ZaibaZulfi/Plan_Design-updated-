Feature: Positive_TC3_MGU_Log
	

@mytag
Scenario:MGU Upload Log   
Given User Should be on Home Page-as Display label "Dashboard" 
When user clicks link Reports.
Then the list of report items will appear
When user clicks link MGU Upload Log 
Then user should be on MGU Upload Log as display label- MGU Upload Log
And user selects MGU code from the MGU code drop down field
When clicks search button
Then the page reloaded as display label- Existing MGU Upload Files
And user perform functions like clicking download icon
And user clicks on next page in pager control
When user clicks view details icon 
Then user should be on MGU Upload Details as display label- MGU Upload Details
And user clicks export to excel button
When user clicks on Account Name in MGU upload details
Then user should be on Account Dashboard as label-Account Dashboard with label
And user clicks on MGU_Upload_Log back