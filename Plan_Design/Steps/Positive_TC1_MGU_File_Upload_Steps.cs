using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoItX3Lib;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Pj.Library;
using TechTalk.SpecFlow;

namespace Plan_Design.Steps
{
    [Binding]
    public class Positive_TC1_MGU_File_UploadSteps
    {
        int flag;
        SETUP setup = new SETUP();
        AutoItX3 autoIt = new AutoItX3();
        
        [Given(@"User Should be on Home Page-as display label ""(.*)""")]
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
        
        [When(@"User clicks search button")]
        public void WhenUserClicksSearchButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(42), propertytype.XPath);
        }
        [Then(@"The list of search item will appear")]
        
        public void ThenTheListOfSearchItemWillAppear()
        {
            CustomControls.Wait();
            Console.WriteLine("List of drop down items are :");
            ListOfItems.Items();

        }
         
        [When(@"User Clicks Link Document search")]
        public void WhenUserClicksLinkDocumentSearch()
        {
            CustomControls.Wait();           
            CustomControls.click(PageObjects.Login_Screen(43), propertytype.XPath);                  


        }
        [Then(@"User should be on document search page-as display label Document Search")]
        public void ThenUserShouldBeOnDocumentSearchPage_AsDisplayLabelDocumentSearch()
        {
            try
            {
                CustomControls.Wait();
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div/h2)[1]"));
                Assert.AreEqual("Document Search", Field.Text);
                Console.WriteLine("Assertion Pass");
            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }

        [When(@"User Clicks link MGU File upload")]
        public void WhenUserClicksLinkMGUFileUpload()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(44), propertytype.XPath);
        }
        [Then(@"User should be on file upload page")]
        public void ThenUserShouldBeOnFileUploadPage()
        {
            try
            {
                CustomControls.Wait();
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div)[149]"));
                Assert.AreEqual("* MGU Code", Field.Text);
                Console.WriteLine("Assertion Pass");
            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                Console.WriteLine("Assertion Fail");

            }
        }
        [Then(@"User Enters MGU Code")]
        public void ThenUserEntersMGUCode()
        {
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control error-aon-blur'])[3]")).SendKeys("MGU012");
        }
        [When(@"User Clicks link upload the file")]
        public void WhenUserClicksLinkUploadTheFile()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(46), propertytype.XPath);
        }
        [Then(@"User will redirect to the folder from which file is to be upload")]
        public void ThenUserWillRedirectToTheFolderFromWhichFileIsToBeUpload()
        {
            autoIt.WinActivate("Open");
            CustomControls.Wait();
            autoIt.Send(@"C:\Users\EXP-10009\Desktop");
            CustomControls.Wait();
            autoIt.Send("{ENTER}");
        }
        [Then(@"User Select the file and upload")]
        public void ThenUserSelectTheFileAndUpload()
        {
            CustomControls.Wait();
            autoIt.Send("MGU012_05-04-2021 (23)");
            CustomControls.Wait();
            autoIt.Send("{ENTER}");
        }

        [When(@"User clicks to submit the file for processing")]
        public void WhenUserClicksToSubmitTheFileForProcessing()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(47), propertytype.XPath);
        }
        [Then(@"User should get the successfully file uploaded pop up")]
        public void ThenUserShouldGetTheSuccessfullyFileUploadedPopUp()
        {
            try
            {
                CustomControls.Wait();
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//h4)[4]"));
                Assert.AreEqual("Bound Busines File Upload", Field.Text);
                Console.WriteLine("Assertion Pass");
            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                IWebElement Field1 = PropertiesCollection.ngdriver.FindElement(By.XPath("(//p/span)[3]"));
                Console.WriteLine(Field1.Text);


            }
        }
        [When(@"User clicks on pop up message")]
        public void WhenUserClicksOnPopUpMessage()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(48), propertytype.XPath);
            IWebElement Field1 = PropertiesCollection.ngdriver.FindElement(By.XPath("(//p/span)[3]"));
            Console.WriteLine(Field1.Text);
        }
        [Then(@"User should be again on file upload page")]
        public void ThenUserShouldBeAgainOnFileUploadPage()
        {
            try
            {
                CustomControls.Wait();
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//div)[149]"));
                Assert.AreEqual("* MGU Code", Field.Text);
                Console.WriteLine("Assertion Pass");
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
