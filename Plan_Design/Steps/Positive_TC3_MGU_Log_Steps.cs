using System;
using System.Collections.Generic;
using AutoItX3Lib;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using Xceed.Wpf.Toolkit;

namespace Plan_Design.Steps
{
    [Binding]
    public class Positive_TC3_MGU_LogSteps
    {
        int flag;
        SETUP setup = new SETUP();
        AutoItX3 autoIt = new AutoItX3();
        [Given(@"User Should be on Home Page-as Display label ""(.*)""")]
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
        
        [When(@"user clicks link Reports\.")]
        public void WhenUserClicksLinkReports_()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(32), propertytype.XPath);
        }
        [Then(@"the list of report items will appear")]
        public void ThenTheListOfReportItemsWillAppear()
        {
            CustomControls.Wait();
            Console.WriteLine("List of drop down items are :");
            ListOfItems.Items();
                  
        }
     

        [When(@"user clicks link MGU Upload Log")]
        public void WhenUserClicksLinkMGUUploadLog()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(33), propertytype.XPath);
        }
        [Then(@"user should be on MGU Upload Log as display label- MGU Upload Log")]
        public void ThenUserShouldBeOnMGUUploadLogAsDisplayLabel_MGUUploadLog()
        {
            try
            {
                CustomControls.Wait();
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div)[103]"));
                Assert.AreEqual("MGU Upload Log", Field.Text);
                Console.WriteLine("Assertion Pass");
            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }
        [Then(@"user selects MGU code from the MGU code drop down field")]
        public void ThenUserSelectsMGUCodeFromTheMGUCodeDropDownField()
        {
            CustomControls.Wait();
            new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath("//select[@class='form-control error-aon-blur']"))).SelectByText("MGU012");
        }

        [When(@"clicks search button")]
        public void WhenClicksSearchButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(35), propertytype.XPath);
        }
        [Then(@"the page reloaded as display label- Existing MGU Upload Files")]
        public void ThenThePageReloadedAsDisplayLabel_ExistingMGUUploadFiles()
        {
            try
            {
                CustomControls.Wait();
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div)[139]"));
                Assert.AreEqual("Existing MGU Upload Files", Field.Text);
                Console.WriteLine("Assertion Pass");
            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }
        [Then(@"user clicks on next page in pager control")]
        public void ThenUserClicksOnNextPageInPagerControl()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(85), propertytype.XPath);
        }
        [Then(@"user perform functions like clicking download icon")]
        public void ThenUserPerformFunctionsLikeClickingDownloadIcon()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(86), propertytype.XPath);
        }
        [When(@"user clicks view details icon")]
        public void WhenUserClicksViewDetailsIcon()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(87), propertytype.XPath);
        }
        [Then(@"user should be on MGU Upload Details as display label- MGU Upload Details")]
        public void ThenUserShouldBeOnMGUUploadDetailsAsDisplayLabel_MGUUploadDetails()
        {
            try
            {
                CustomControls.Wait();
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div)[103]"));
                Assert.AreEqual("MGU Upload Log Details", Field.Text);
                Console.WriteLine("Assertion Pass");
            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }
        [Then(@"user clicks export to excel button")]
        public void ThenUserClicksExportToExcelButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(39), propertytype.XPath);
        }

        [When(@"user clicks on Account Name in MGU upload details")]
        public void WhenUserClicksOnAccountNameInMGUUploadDetails()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(88), propertytype.XPath);
        }
        [Then(@"user should be on Account Dashboard as label-Account Dashboard with label")]
        public void ThenUserShouldBeOnAccountDashboardAsLabel_AccountDashboardWithLabel()
        {
            try
            {
                CustomControls.Wait();
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2/span)[1]"));
                Assert.AreEqual("Account Dashboard : Test_Plan 02_Harrington_IA 2nd Retest - PAI L0120002020219\r\nStatus: Issued", Field.Text);
                Console.WriteLine("Assertion Pass");
            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }

        [Then(@"user clicks on MGU_Upload_Log back")]
        public void ThenUserClicksOnMGU_Upload_LogBack()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(41), propertytype.XPath);
        }

















    }
}
