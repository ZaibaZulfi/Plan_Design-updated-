using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;



namespace Plan_Design.Steps
{
    [Binding]
    public class Positive_TC6_Create_RFP_Steps
    {
        int flag;
        SETUP setup = new SETUP();
        [Given(@"User Should be on Home Page-As display label ""(.*)""")]
        public void GivenUserShouldBeOnHomePage_AsDisplayLabel(string dashboard)
        {
            setup.TestMethodLogin(Globalelements.url);
            PropertiesCollection.ngdriver.Manage().Window.Maximize();
            CustomControls.Entertext(PageObjects.Login_Screen(1), Globalelements.username, propertytype.CssSelector);
            CustomControls.Entertext(PageObjects.Login_Screen(2), Globalelements.password, propertytype.CssSelector);
            CustomControls.click(PageObjects.Login_Screen(3), propertytype.CssSelector);
            implicitwait.ImplicitWait(20);

            try
            {
                Globalelements.Actualresult = CustomControlGets.GettextfromLabel(PageObjects.Login_Screen(4), propertytype.XPath);
            }
            catch (Exception)
            {
                flag = 1;

            }

            finally
            {
                Globalelements.Expectedresult = dashboard;
                Console.WriteLine(Globalelements.Actualresult);
                if (flag == 1)
                {
                    Console.WriteLine(" Test case failed, the User is not able to Login");
                }
                Assertions.assertionequals(Globalelements.Actualresult, Globalelements.Expectedresult);
            }
        }
        
        [Given(@"User clicks link Underwriting\.")]
        public void GivenUserClicksLinkUnderwriting_()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(5), propertytype.XPath);
        }
        
        [When(@"User clicks link New RFP")]
        public void WhenUserClicksLinkNewRFP()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(89), propertytype.XPath);
        }
        [Then(@"User should be on Submission Screen")]
        public void ThenUserShouldBeOnSubmissionScreen()
        {
            CustomControls.Wait();
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[7]"));
                Assert.AreEqual("Submission", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }

        [Then(@"User Enters Proposed Due Date")]
        public void ThenUserEntersProposedDueDate()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(90), propertytype.XPath);

            //click on Proposed Due Date==>"Today"
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(91), propertytype.XPath);
        }

        [Then(@"User Enters Proposed Effective Date")]
        public void ThenUserEntersProposedEffectiveDate()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(92), propertytype.XPath);
            
            //click on Proposed Effective Date==>ex 'August 2020'
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(93), propertytype.XPath);

            //click on Proposed Effective Date==>ex '>>'
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(94), propertytype.XPath);

            //click on Proposed Effective Date==>ex 'month'
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(95), propertytype.XPath);

            //click on Proposed Effective Date==>ex 'day'
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(96), propertytype.XPath);
        }

        [Then(@"User Enters Account Name")]
        public void ThenUserEntersAccountName()
        {
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control'])[5]")).SendKeys("Eight");
        }

        [Then(@"User Enters Address(.*)")]
        public void ThenUserEntersAddress(int p0)
        {
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control'])[6]")).SendKeys("Add1");
        }

        [Then(@"User Enters Add(.*)")]
        public void ThenUserEntersAdd(int p0)
        {
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control'])[7]")).SendKeys("Add2");
        }
    
        [Then(@"User Enters City")]
        public void ThenUserEntersCity()
        {
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control'])[8]")).SendKeys("city");
        }

        [Then(@"User Enters State")]
        public void ThenUserEntersState()
        {
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control'])[1]"))).SelectByText("Alaska");
        }

        [Then(@"User Enters Zip")]
        public void ThenUserEntersZip()
        {
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control'])[9]")).SendKeys("123456");
        }

        [Then(@"User select Market Segment")]
        public void ThenUserSelectMarketSegment()
        {
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control'])[2]"))).SelectByText("Education");
        }

        [Then(@"User select Customer Segment")]
        public void ThenUserSelectCustomerSegment()
        {
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control'])[3]"))).SelectByText("Day care - (PAI)");
        }

        [Then(@"User select Product Selection")]
        public void ThenUserSelectProductSelection()
        {
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control'])[4]"))).SelectByText("Participant Accident");
        }

        [Then(@"User select Available Group Type")]
        public void ThenUserSelectAvailableGroupType()
        {
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control'])[5]"))).SelectByText("Educational Organization");
        }

        [Then(@"User select Available Form")]
        public void ThenUserSelectAvailableForm()
        {
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control'])[6]"))).SelectByText("Participant Accident - AH51051");
        }

        [Then(@"User select Sales Contact")]
        public void ThenUserSelectSalesContact()
        {
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control'])[7]"))).SelectByText("Terrence Reid");
        }

        [Then(@"User select Region")]
        public void ThenUserSelectRegion()
        {
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control'])[8]"))).SelectByText("Mid-Atlantic");
        }

        [Then(@"User select Assigned Underwriter")]
        public void ThenUserSelectAssignedUnderwriter()
        {
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control'])[9]"))).SelectByText("Cheryl Lawrence");
        }
        [When(@"User clicks Next button")]
        public void WhenUserClicksNextButton()
        {
            CustomControls.Wait();
            CustomControls.Btn_Next_RFP();
        }

        [Then(@"User should be on Producer screen")]
        public void ThenUserShouldBeOnProducerScreen()
        {
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[7]"));
                Assert.AreEqual("Producer\r\nAdd Agency", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }

        [Then(@"User Enters Agency")]
        public void ThenUserEntersAgency()
        {
            //Producer
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(97), propertytype.XPath);

            //Agency
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='input form-control custom-height'])[1]")).SendKeys("006");

            //Agency search 
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(99), propertytype.XPath);

            //Agency==>select agency
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(100), propertytype.XPath);
        }

        [Then(@"User Enters Agent")]
        public void ThenUserEntersAgent()
        {
            //* Agent
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(101), propertytype.XPath);

            //* Agent==>Search
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(102), propertytype.XPath);
        }

        [Then(@"User select Distribution Source")]
        public void ThenUserSelectDistributionSource()
        {
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control error-aon-blur'])[1]"))).SelectByText("Affinity/Association Partner (no producer involvement)");
        }

        [Then(@"User Clicks on Save")]
        public void ThenUserClicksOnSave()
        {
            CustomControls.Wait();
            CustomControls.Btn_Save_RFP();
        }
        [When(@"User clicks on Next button")]
        public void WhenUserClicksOnNextButton()
        {
            CustomControls.Wait();
            CustomControls.Btn_Next_RFP();
        }

        [Then(@"User should be on Account Clearance")]
        public void ThenUserShouldBeOnAccountClearance()
        {
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[7]"));
                Assert.AreEqual("Account Clearance", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }
        [When(@"User Clicks on Proceed for Rating")]
        public void WhenUserClicksOnProceedForRating()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(103), propertytype.XPath);
        }

        [Then(@"User should be on Additional Policy Information/Plan Design")]
        public void ThenUserShouldBeOnAdditionalPolicyInformationPlanDesign()
        {
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[8]"));
                Assert.AreEqual("Additional Policy Information/Plan Design\r\n   ", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }
        [When(@"User clicks on Plan_Design Next Button")]
        public void WhenUserClicksOnPlan_DesignNextButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(104), propertytype.XPath);
        }

        [Then(@"User should be on Census Page")]
        public void ThenUserShouldBeOnCensusPage()
        {
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[7]"));
                Assert.AreEqual("Census\r\n   ", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }
        [When(@"User clicks on Census_Next button")]
        public void WhenUserClicksOnCensus_NextButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(104), propertytype.XPath);
        }

       [Then(@"User should be on Class Detail Screen")]
        public void ThenUserShouldBeOnClassDetailScreen()
        {
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[7]"));
                Assert.AreEqual("Class Detail\r\nAdd Class", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }

        [Then(@"User Enters Class Number")]
        public void ThenUserEntersClassNumber()
        {
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.Id("ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_cntrl8p2668_txtAClassCode")).SendKeys("1");
        }

        [Then(@"User select Description")]
        public void ThenUserSelectDescription()
        {
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.Id("ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_cntrl8p2668_drpListClass"))).SelectByText("All registered day care participants of the Policyholder.");
        }

        [Then(@"User clicks save button")]
        public void ThenUserClicksSaveButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(65), propertytype.XPath);
        }

        [Then(@"User Enters Class under Day-care section")]
        public void ThenUserEntersClassUnderDay_CareSection()
        {
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control textboxnumeric error-aon-blur'])[1]")).SendKeys("1");
        }

        [Then(@"User Enters Headcount under Day-care section")]
        public void ThenUserEntersHeadcountUnderDay_CareSection()
        {
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control textboxnumeric error-aon-blur'])[2]")).SendKeys("15");
        }

        [Then(@"User Enters Actual Exposure under Day-care section")]
        public void ThenUserEntersActualExposureUnderDay_CareSection()
        {
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control textboxnumeric error-aon-blur'])[5]")).SendKeys("151");
        }

        [When(@"User Clicks Class_Details Next button")]
        public void WhenUserClicksClass_DetailsNextButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(104), propertytype.XPath);
        }

       [Then(@"User should be on Class (.*) – Hazards")]
        public void ThenUserShouldBeOnClassHazards(int p0)
        {
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[7]"));
                Assert.AreEqual("Class 1 - Hazards\r\n   ", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }

        [Then(@"User select (.*) Hour Coverage")]
        public void ThenUserSelectHourCoverage(int p0)
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(105), propertytype.XPath);
        }

        [Then(@"User select School Coverage")]
        public void ThenUserSelectSchoolCoverage()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(106), propertytype.XPath);
        }

        [Then(@"User select Supervised and Sponsored Activities")]
        public void ThenUserSelectSupervisedAndSponsoredActivities()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(107), propertytype.XPath);
        }

        [Then(@"User select Sports Coverage")]
        public void ThenUserSelectSportsCoverage()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(108), propertytype.XPath);
        }

        [Then(@"User select an option from Class (.*) – Covered Activities")]
        public void ThenUserSelectAnOptionFromClassCoveredActivities(int p0)
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(109), propertytype.XPath);
        }
        [When(@"User Clicks Hazard Next button")]
        public void WhenUserClicksHazardNextButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(104), propertytype.XPath);
        }

       [Then(@"User should be on Class (.*) –Accidental Death & Dismemberment")]
        public void ThenUserShouldBeOnClassAccidentalDeathDismemberment(int p0)
        {
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[7]"));
                Assert.AreEqual("Class 1 - Accidental Death & Dismemberment\r\n   ", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }
        [When(@"User Clicks AD&D Next button")]
        public void WhenUserClicksADDNextButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(104), propertytype.XPath);
        }
     

        [Then(@"User should be on Class (.*) –Accident Medical and Dental Expense")]
        public void ThenUserShouldBeOnClassAccidentMedicalAndDentalExpense(int p0)
        {
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[7]"));
                Assert.AreEqual("Class 1 - Accident Medical and Dental Expense\r\n   ", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }
        [When(@"User Clicks AMD Next button")]
        public void WhenUserClicksAMDNextButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(104), propertytype.XPath);
        }
    
        [Then(@"User should be on Additional Benefit Checklist for class (.*)")]
        public void ThenUserShouldBeOnAdditionalBenefitChecklistForClass(int p0)
        {
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[7]"));
                Assert.AreEqual("Additional Benefit Checklist for Class 1\r\nSelect All\r\nSelect None", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }

        [Then(@"User select the benefits")]
        public void ThenUserSelectTheBenefits()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(110), propertytype.XPath);
        }
        [When(@"User Clicks AB Next button")]
        public void WhenUserClicksABNextButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(104), propertytype.XPath);
        }
    
        [Then(@"User should be on Class (.*) –Accidental Burn & Disfigurement")]
        public void ThenUserShouldBeOnClassAccidentalBurnDisfigurement(int p0)
        {
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[7]"));
                Assert.AreEqual("Class 1 - Accidental Burn & Disfigurement\r\n   ", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }

        [Then(@"User select Burn Classification under Accidental Burn & Disfigurement")]
        public void ThenUserSelectBurnClassificationUnderAccidentalBurnDisfigurement()
        {
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control error-aon-blur'])[1]"))).SelectByText("Second");
        }

        [Then(@"User Enters Deductible under class (.*)-Life Adjustment")]
        public void ThenUserEntersDeductibleUnderClass_LifeAdjustment(int p0)
        {
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control textboxnumeric error-aon-blur'])[5]")).SendKeys("200");
        }

        [Then(@"User Enters Loss Earnings Benefits Period Max under Class (.*)-Life Adjustment")]
        public void ThenUserEntersLossEarningsBenefitsPeriodMaxUnderClass_LifeAdjustment(int p0)
        {
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control textboxnumeric error-aon-blur'])[10]")).SendKeys("20");
        }

      
        [Then(@"User select % of Principal Sum under Coma Benefit")]
        public void ThenUserSelectOfPrincipalSumUnderComaBenefit()
        {
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control error-aon-blur'])[3]"))).SelectByText("2%");
        }

        [Then(@"User select Benefit Offering under Class (.*)- Disability")]
        public void ThenUserSelectBenefitOfferingUnderClass_Disability(int p0)
        {
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control error-aon-blur'])[4]"))).SelectByText("Permanently Totally Disabled");
        }

        [Then(@"User select Payment Options under Class (.*)- Disability")]
        public void ThenUserSelectPaymentOptionsUnderClass_Disability(int p0)
        {
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control error-aon-blur'])[5]"))).SelectByText("Monthly Payment");
        }
        [Then(@"User Enters maximum benefit amount under Class (.*)-Emergency Medical Evacuation")]
        public void ThenUserEntersMaximumBenefitAmountUnderClass_EmergencyMedicalEvacuation(int p0)
        {
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control textboxnumeric error-aon-blur'])[20]")).SendKeys("150000");
        }
        [When(@"User Clicks on ABD Next button")]
        public void WhenUserClicksOnABDNextButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(104), propertytype.XPath);
        }

     
        [Then(@"User should be on Services screen")]
        public void ThenUserShouldBeOnServicesScreen()
        {
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[7]"));
                Assert.AreEqual("Services\r\n   ", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }

        [Then(@"User Enters Travel Assistance Services")]
        public void ThenUserEntersTravelAssistanceServices()
        {
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control textboxnumeric error-aon-blur'])[1]")).SendKeys("150");
        }

        [When(@"User Clicks on Service Next button")]
        public void WhenUserClicksOnServiceNextButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(104), propertytype.XPath);
        }
     
        [Then(@"User should be on Policy Exclusions & Limitations")]
        public void ThenUserShouldBeOnPolicyExclusionsLimitations()
        {
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[7]"));
                Assert.AreEqual("Policy Exclusions & Limitations", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }

        [When(@"User Clicks on Exclusion Next button")]
        public void WhenUserClicksOnExclusionNextButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(104), propertytype.XPath);
        }

        [Then(@"User should be on Commission & Fee")]
        public void ThenUserShouldBeOnCommissionFee()
        {
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[7]"));
                Assert.AreEqual("Commission & Fee", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }
        [When(@"User Clicks on Commision Next button")]
        public void WhenUserClicksOnCommisionNextButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(104), propertytype.XPath);

        }

        [Then(@"User should be on Experience Rating")]
        public void ThenUserShouldBeOnExperienceRating()
        {
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[7]"));
                Assert.AreEqual("Experience Rating", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }

        [When(@"User Clicks on Skip Experience Rater")]
        public void WhenUserClicksOnSkipExperienceRater()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(111), propertytype.XPath);
        }

        [Then(@"User should be on premium/Rate Summary")]
        public void ThenUserShouldBeOnPremiumRateSummary()
        {
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[7]"));
                Assert.AreEqual("Premium / Rate Summary", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }

        [Then(@"User Clicks on Rating Method Selected")]
        public void ThenUserClicksOnRatingMethodSelected()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(112), propertytype.XPath);
        }
        [When(@"User Clicks on Rating Next button")]
        public void WhenUserClicksOnRatingNextButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(104), propertytype.XPath);
        }
        [Then(@"User should be on After Rating Account Clearance")]
        public void ThenUserShouldBeOnAfterRatingAccountClearance()
        {
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[7]"));
                Assert.AreEqual("Account Clearance", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }
        [When(@"User Clicks on AC Next button")]
        public void WhenUserClicksOnACNextButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(104), propertytype.XPath);
        }
   
       [Then(@"User should be on Generate Proposal")]
        public void ThenUserShouldBeOnGenerateProposal()
        {
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[7]"));
                Assert.AreEqual("Generate Proposal", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }

        [Then(@"User Clicks on Generate Proposal")]
        public void ThenUserClicksOnGenerateProposal()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(113), propertytype.XPath);
        }
        [When(@"User Clicks on Finish")]
        public void WhenUserClicksOnFinish()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(114), propertytype.XPath);
        }
        [Then(@"User should be on ""(.*)""")]
        public void ThenUserShouldBeOn(string home)
        {
            try
            {
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//li)[86]"));
                Assert.AreEqual("Home", Field.Text);
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("The current screeen is: " + Field.Text);

            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
          
        }

      
    }
}
