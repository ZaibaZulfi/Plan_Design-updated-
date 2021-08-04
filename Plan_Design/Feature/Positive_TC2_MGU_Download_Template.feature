Feature: Positive_TC2_MGU_Download_Template
	Simple calculator for adding two numbers

@mytag
Scenario: Downloading MGU_Template
	Given User Should be on Home page-as display label "Dashboard" 
	When User Clicks search
	Then The List of search item will appear
	When  User Clicks link Document search
	And User Clicks button-MGU File Upload 
	And User Enter MGU Code
	And user clicks on Download template