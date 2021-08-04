Feature: Positive_TC4_Create_PlanDesign
	In this feature, we will create, manage the plan design(s)

@mytag
Scenario: Create plan design    
	Given User Should be on home page-as display label "Dashboard" 
	And User clicks link underwriting.    
	When user clicks link manage plan design 
	Then user should be on Manage Plan Design
	When user clicks button-Add New plan Design
	Then user should be on submission screen