Feature: Positive_TC6_Create_RFP
	In this feature, we will create an RFP

@mytag
Scenario: Create an RFP for product PAI 
	Given User Should be on Home Page-As display label "Dashboard" 
	And User clicks link Underwriting.    
	When User clicks link New RFP 
	Then User should be on Submission Screen
	And User Enters Proposed Due Date
	And User Enters Proposed Effective Date
	And User Enters Account Name
	And User Enters Address1
	And User Enters Add2
	And User Enters City
	And User Enters State
	And User Enters Zip
	And User select Market Segment
	And User select Customer Segment
	And User select Product Selection
	And User select Available Group Type
	And User select Available Form
	And User select Sales Contact
	And User select Region
	And User select Assigned Underwriter
	When User clicks Next button
	Then User should be on Producer screen
	And User Enters Agency
	And User Enters Agent
	And User select Distribution Source
	And User Clicks on Save
	When User clicks on Next button
	Then User should be on Account Clearance
	When User Clicks on Proceed for Rating
	Then User should be on Additional Policy Information/Plan Design
	When User clicks on Plan_Design Next Button
	Then User should be on Census Page
	When User clicks on Census_Next button
	Then User should be on Class Detail Screen
	And User Enters Class Number
	And User select Description
	And User clicks save button
	And User Enters Class under Day-care section
	And User Enters Headcount under Day-care section 
	And User Enters Actual Exposure under Day-care section
	When User Clicks Class_Details Next button
	Then User should be on Class 1 – Hazards
	And User select 24 Hour Coverage
	And User select School Coverage
	And User select Supervised and Sponsored Activities
	And User select Sports Coverage
	And User select an option from Class 1 – Covered Activities
	When User Clicks Hazard Next button
	Then User should be on Class 1 –Accidental Death & Dismemberment
	When User Clicks AD&D Next button
	Then User should be on Class 1 –Accident Medical and Dental Expense
	When User Clicks AMD Next button
	Then User should be on Additional Benefit Checklist for class 1
	And User select the benefits
	When User Clicks AB Next button
	Then User should be on Class 1 –Accidental Burn & Disfigurement
	And User select Burn Classification under Accidental Burn & Disfigurement
	And User Enters Loss Earnings Benefits Period Max under Class 1-Life Adjustment
	And User Enters Deductible under class 1-Life Adjustment
	And User select % of Principal Sum under Coma Benefit
	And User select Benefit Offering under Class 1- Disability
	And User select Payment Options under Class 1- Disability
	And User Enters maximum benefit amount under Class 1-Emergency Medical Evacuation
	When User Clicks on ABD Next button
	Then User should be on Services screen
	And User Enters Travel Assistance Services
	When User Clicks on Service Next button
	Then User should be on Policy Exclusions & Limitations
	When User Clicks on Exclusion Next button
	Then User should be on Commission & Fee
	When User Clicks on Commision Next button
	Then User should be on Experience Rating
	When User Clicks on Skip Experience Rater
	Then User should be on premium/Rate Summary
	And User Clicks on Rating Method Selected
	When User Clicks on Rating Next button
	Then User should be on After Rating Account Clearance
	When User Clicks on AC Next button
	Then User should be on Generate Proposal
	And User Clicks on Generate Proposal 
	When User Clicks on Finish.
	Then User should be on "Dashboard"
