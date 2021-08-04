using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace Plan_Design.Steps
{
    [Binding]
    public class Positive_TC4_Create_PlanDesignSteps
    {
        int flag;
        SETUP setup = new SETUP();
        [Given(@"User Should be on home page-as display label ""(.*)""")]
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
        
        [Given(@"User clicks link underwriting\.")]
        public void GivenUserClicksLinkUnderwriting_()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(5), propertytype.XPath);
        }
        
        [When(@"user clicks link manage plan design")]
        public void WhenUserClicksLinkManagePlanDesign()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(6), propertytype.XPath);
        }
        
        [When(@"user clicks button-Add New plan Design")]
        public void WhenUserClicksButton_AddNewPlanDesign()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(8), propertytype.XPath);
        }
        [Then(@"user should be on Manage Plan Design")]
        public void ThenUserShouldBeOnManagePlanDesign()
        {
            try
            {
                CustomControls.Wait();
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//h2/span)[2]"));
                Assert.AreEqual("Plan Design", Field.Text);
                Console.WriteLine("Assertion Pass");
            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
            }
        }
                
        [Then(@"user should be on submission screen")]
        public void ThenUserShouldBeOnSubmissionScreen()
        {
            //Plan Design Name
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.Id("ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxb7fee7aa-ded9-4f00-a614-c205a704ca53")).SendKeys("PD1_Aug_4");

            //Effective Date
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(55), propertytype.XPath);

            //Effective Date--->CLICK "Today"
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(56), propertytype.XPath);

            //Expiration Date
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(57), propertytype.XPath);

            //Expiration Date--->CLICK May 2021
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(58), propertytype.XPath);

            //Expiration Date--->CLICK ">>"
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(59), propertytype.XPath);

            //Expiration Date--->CLICK MONTH(EX: MAY)
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(60), propertytype.XPath);

            //Expiration Date--->CLICK Date
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(61), propertytype.XPath);

            //Select All States
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(80), propertytype.XPath);

            //Market Segment
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(62), propertytype.XPath);

            //Market Segment--->select drop down
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("//select[@class='form-control error-aon-blur']"))).SelectByText("Amateur Sports & Recreation");

            //Customer Segment
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.Id("ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpl165f01be-5ad8-496e-85f5-7f5745e45462"))).SelectByText("Youth Sports - (PAI)");

            //Product Selection
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.Id("ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpl71437492-8fbd-497a-ac84-df35abf2c6e5"))).SelectByText("Youth Sports - Standard Risk");

            //Available Group Type
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.Id("ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpla1602ad7-726b-4452-ae07-73469618a59d"))).SelectByText("Recreational Organization");

            //Available Form
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.Id("ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpl6269d11a-a63c-4b81-83d6-da47d249c77f"))).SelectByText("BLHIC-Participant Accident - AH51051");

            //Next Button
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(63), propertytype.XPath);

            //Census==>Amateur Sports
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(64), propertytype.XPath);

            //Next Button
            CustomControls.Wait();
            CustomControls.Btn_Next();

            //Class Number
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.Id("ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_cntrl8p2668_txtAClassCode")).SendKeys("1");

            //Description
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.Id("ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_cntrl8p2668_drpListClass"))).SelectByText("All registered participants of the Policyholder.");

            //class detail "save"
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(65), propertytype.XPath);

            //Next Button
            CustomControls.Wait();
            CustomControls.Btn_Next();

            //class 1 hazard (24 Hour Coverage)
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(66), propertytype.XPath);

            //class 1 hazard (School Coverage)
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(67), propertytype.XPath);

            //class 1 hazard (School Coverage)==>Limitation Under Multiple Hazards
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(68), propertytype.XPath);

            //Class 1 - Covered Activities
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(69), propertytype.XPath);

            //Next Button
            CustomControls.Wait();
            CustomControls.Btn_Next();

            //Class 1 - Accidental Death & Dismemberment
            //Next Button
            CustomControls.Wait();
            CustomControls.Btn_Next();

            //Class 1 - Accident Medical and Dental Expense
            //Catastrophic Deductible must be incurred within1
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control'])[1]"))).SelectByText("30 days");

            //N Button
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(70), propertytype.XPath);

            //Additional Benefit Checklist for Class 1
            //SELECT ALL
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(71), propertytype.XPath);

            //Next Button
            CustomControls.Wait();
            CustomControls.Btn_Next();

            //Class 1 - Accidental Burn & Disfigurement
            //*Burn Classification
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control error-aon-blur'])[1]"))).SelectByText("Second");

            //Class 1 - Life Adjustment
            //1. Deductible
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("//input[@fname='Deductible']")).SendKeys("200");

            //Class 1 - Life Adjustment
            //2. Loss Earnings Benefit Period Max
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("//input[@fname='Loss Earnings Benefit Period Max']")).SendKeys("15");

            //Class 1 - Coma
            //1. * % of Principal Sum
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control error-aon-blur'])[3]"))).SelectByText("2%");

            //Class 1 - Disability
            //1.Benefit Offering
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control error-aon-blur'])[4]"))).SelectByText("Permanently Totally Disabled");

            //2.Payment Options
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control error-aon-blur'])[5]"))).SelectByText("Monthly Payment");

            //Next Button
            CustomControls.Wait();
            CustomControls.Btn_Next();

            //Services
            //Please enter estimated number of lives
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control textboxnumeric error-aon-blur'])[1]")).SendKeys("15");

            //Next Button
            CustomControls.Wait();
            CustomControls.Btn_Next();

            //Policy Exclusions & Limitations
            //Next Button
            CustomControls.Wait();
            CustomControls.Btn_Next();

            //Setup Billing & Collection Options
            //1.  Commission Netted:
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(72), propertytype.XPath);

            //2.TPA Fee Netted:
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(73), propertytype.XPath);

            //Premium Schedule :
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control error-aon-blur'])[1]"))).SelectByText("Annual");

            // paid : 
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control numeric error-aon-blur'])[1]")).SendKeys("5");

            //day in 
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("(//select[@class='form-control error-aon-blur'])[2]"))).SelectByText("In Advance");

            //Number of Installments :
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control numeric error-aon-blur'])[2]")).SendKeys("2");

            //Next Button
            CustomControls.Wait();
            CustomControls.Btn_Next();

            //Review/Verify Plan Design
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(74), propertytype.XPath);

            //* Complete description of change:
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("//textarea[@class='form-control error-aon-blur']")).SendKeys("Description of test scenario");

            //Next Button
            try
            {
                CustomControls.Wait();
                CustomControls.Btn_Next();
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }

            delayfor.delay();
            CustomControls.click(PageObjects.Login_Screen(75), propertytype.XPath);








        
         }
    }
}
