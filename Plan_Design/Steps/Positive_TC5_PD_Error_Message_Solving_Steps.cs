using System;
using TechTalk.SpecFlow;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Plan_Design.Steps
{
    [Binding]
    public class Positive_TC5_PD_Error_Message_Solving_Steps
    {
        int flag;
        SETUP setup = new SETUP();
        [Given(@"User should be on home page-as display label ""(.*)""")]
        public void GivenUserShouldBeOnHomePage_AsDisplayLabel(string dashboard)
        {
            setup.TestMethodLogin(Globalelements.url);
            PropertiesCollection.ngdriver.Manage().Window.Maximize();
            CustomControls.Entertext(PageObjects.Login_Screen(1), Globalelements.username, propertytype.CssSelector);
            CustomControls.Entertext(PageObjects.Login_Screen(2), Globalelements.password, propertytype.CssSelector);
            CustomControls.click(PageObjects.Login_Screen(3), propertytype.CssSelector);
            implicitwait.ImplicitWait(30);

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

        [Given(@"user clicks link underwriting\.")]
        public void GivenUserClicksLinkUnderwriting_()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(5), propertytype.XPath);
        }

        [Given(@"user clicks link manage plan design")]
        public void GivenUserClicksLinkManagePlanDesign()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(6), propertytype.XPath);

        }

        [Given(@"user clicks button-Add New plan Design")]
        public void GivenUserClicksButton_AddNewPlanDesign()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(8), propertytype.XPath);
        }
        [Given(@"User enters data in the submission-screen fields")]
        public void GivenUserEntersDataInTheSubmission_ScreenFields()
        {
            //Plan Design Name
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.Id("ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxb7fee7aa-ded9-4f00-a614-c205a704ca53")).SendKeys("PLAN-13");

            //Effective Date
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.Id("ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtx90381e48-8cb8-4032-9a3d-9c77b9656d12")).Click();

            //Effective Date--->CLICK "Today"
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//th[text()='Today'])[1]")).Click();

            //Expiration Date
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.Id("ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtx3ecb3ec1-dc1b-4e21-b240-424fd3d66332")).Click();

            //Expiration Date--->CLICK May 2021
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//th[@class='datepicker-switch'])[1]")).Click();

            //Expiration Date--->CLICK ">>"
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//th[@class='next'])[2]")).Click();

            //Expiration Date--->CLICK MONTH(EX: MAY)
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("//span[text()='May']")).Click();

            //Expiration Date--->CLICK Date
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//td[text()='18'])[2]")).Click();

            //select Alaska state
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(52), propertytype.XPath);

            //select Vermont state
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(54), propertytype.XPath);
            /*
            //Select All States
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//ins[@class='iCheck-helper'])[1]")).Click();*/

            //Market Segment
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.Id("ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpladac9c07-bcb2-4090-937b-767fbf8fac3f")).Click();

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
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//a[@class='btn btn-primary'])[2]")).Click();

            //Census==>Amateur Sports
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//ins[@class='iCheck-helper'])[3]")).Click();

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
            PropertiesCollection.ngdriver.FindElement(By.Id("ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_cntrl8p2668_lnkAdd")).Click();

            //Next Button
            CustomControls.Wait();
            CustomControls.Btn_Next();

            //class 1 hazard (24 Hour Coverage)
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//ins[@class='iCheck-helper'])[1]")).Click();

            //class 1 hazard (School Coverage)
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//ins[@class='iCheck-helper'])[42]")).Click();

            //class 1 hazard (School Coverage)==>Limitation Under Multiple Hazards
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//ins[@class='iCheck-helper'])[43]")).Click();

            //Class 1 - Covered Activities
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//ins[@class='iCheck-helper'])[154]")).Click();

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
            PropertiesCollection.ngdriver.FindElement(By.XPath("//input[@class='btn btn-primary jqhandlenextbutton']")).Click();

            //Additional Benefit Checklist for Class 1
            //SELECT ALL
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("//a[@onclick='return CheckUnCheckGrid1(1);']")).Click();

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
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//ins[@class='iCheck-helper'])[5]")).Click();

            //2.TPA Fee Netted:
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//ins[@class='iCheck-helper'])[7]")).Click();

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
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//ins[@class='iCheck-helper'])[2]")).Click();

            //* Complete description of change:
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("//textarea[@class='form-control error-aon-blur']")).SendKeys("Description of test scenario");

            //Next Button
            CustomControls.Wait();
            CustomControls.Btn_Next();

            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.Id("ctl00_cphMain_cntrlCoverageAddEdit_ConfirmMessageBoxChange_btnConfirm")).Click();
        }
        [When(@"user clicks on down arrow in Manage Plan Design")]
        public void WhenUserClicksOnDownArrowInManagePlanDesign()
        {
            //click on DOWN ARROW in manage Plan design
            delayfor.delay();
            CustomControls.click(PageObjects.Login_Screen(76), propertytype.XPath);
        }

        [When(@"user click on Alaska state")]
        public void WhenUserClickOnAlaskaState()
        {
            //Alaska State
            //Class 1 Alaska>Hazards :: Independent Contractor Coverage - [IndependentContractorCoverage]  is not applicable/allowed in AK
            delayfor.delay();
            CustomControls.click(PageObjects.Login_Screen(77), propertytype.XPath);
        }
        [When(@"User Enters data in the fields")]
        public void WhenUserEntersDataInTheFields()
        {
            //click next in AME
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(70), propertytype.XPath);

            //click next in Additional Benefit Checklist for Class 1
            CustomControls.Wait();
            CustomControls.Btn_Next();

            //click next in Class 1 - Accidental Burn & Disfigurement
            CustomControls.Wait();
            CustomControls.Btn_Next();

            //click next in Services
            CustomControls.Wait();
            CustomControls.Btn_Next();

            //click next in  Policy Exclusions &Limitations
            CustomControls.Wait();
            CustomControls.Btn_Next();

            CustomControls.Wait();
            CustomControls.Btn_Next();

            CustomControls.Wait();
            CustomControls.Btn_Next();


            //click next in  Setup Billing &Collection Options==>Premium Change Notice 
            CustomControls.Wait();
            IWebElement f1 = PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control numeric error-aon-blur'])[4]"));
            f1.Clear();
            f1.SendKeys("50");

            //click next in  Setup Billing &Collection Options
            CustomControls.Wait();
            CustomControls.Btn_Next();

            //click next in  Run verification of Plan Design
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(74), propertytype.XPath);

            //Complete description of change:
            PropertiesCollection.ngdriver.FindElement(By.XPath("//textarea[@class='form-control error-aon-blur']")).SendKeys("Description of test1 scenario");

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
               
        [When(@"user Clicks on Down arrow in ""(.*)""")]
        public void WhenUserClicksOnDownArrowIn(string Manage)
        {
            //click on DOWN ARROW in manage Plan design
            delayfor.delay();
            CustomControls.click(PageObjects.Login_Screen(76), propertytype.XPath);
        }
        [When(@"user click on Vermont state")]
        public void WhenUserClickOnVermontState()
        {
            //VT state
            //Class 1 Vermont Class 1> Accident Medical and Dental Expense :: weeks option is not available for AME - [Period] in VT
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(78), propertytype.XPath);
        }
        [When(@"User Enters Data in the fields from ""(.*)""")]
        public void WhenUserEntersDataInTheFieldsFrom(string AME)
        {
            //click next in AME
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(70), propertytype.XPath);

            //click next in Additional Benefit Checklist for Class 1
            CustomControls.Wait();
            CustomControls.Btn_Next();

            //click next in Class 1 - Accidental Burn & Disfigurement
            CustomControls.Wait();
            CustomControls.Btn_Next();

            //click next in Services
            CustomControls.Wait();
            CustomControls.Btn_Next();

            //click next in  Policy Exclusions &Limitations
            CustomControls.Wait();
            CustomControls.Btn_Next();
            CustomControls.Wait();
            CustomControls.Btn_Next();

            CustomControls.Wait();
            CustomControls.Btn_Next();

            //click next in  Setup Billing &Collection Options==>Premium Change Notice 
            IWebElement f2 = PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control numeric error-aon-blur'])[4]"));
            f2.Clear();
            f2.SendKeys("50");

            //click next in  Setup Billing &Collection Options
            CustomControls.Wait();
            CustomControls.Btn_Next();

            //click next in  Run verification of Plan Design
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(74), propertytype.XPath);

            //Complete description of change:
            PropertiesCollection.ngdriver.FindElement(By.XPath("//textarea[@class='form-control error-aon-blur']")).SendKeys("Description of test1 scenario");

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

