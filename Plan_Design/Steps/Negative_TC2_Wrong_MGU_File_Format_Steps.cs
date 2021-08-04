﻿using System;
using System.Collections.Generic;
using AutoItX3Lib;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Plan_Design.Steps
{
    [Binding]
    public class Negative_TC2_Wrong_MGU_File_FormatSteps
    {
        int flag;
        SETUP setup = new SETUP();
        AutoItX3 autoIt = new AutoItX3();
        
        [Given(@"User Should be on Home Page-as Display Label ""(.*)""")]
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
        
        [When(@"User Clicks search button")]
        public void WhenUserClicksSearchButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(42), propertytype.XPath);
        }
        [Then(@"The List of Search item will appear")]
        public void ThenTheListOfSearchItemWillAppear()
        {
            CustomControls.Wait();
           // Console.WriteLine("List of drop down items are :");
            ListOfItems.Items();
        }


        [When(@"User Clicks Link Document Search")]
        public void WhenUserClicksLinkDocumentSearch()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(43), propertytype.XPath);
        }
        [Then(@"User Should be on document search page-as display label Document Search")]
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

        [When(@"User Clicks Link MGU File upload")]
        public void WhenUserClicksLinkMGUFileUpload()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(44), propertytype.XPath);
        }
        [Then(@"User Should be on file upload page")]
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
        [Then(@"User Enters MGU- Code")]
        public void ThenUserEntersMGU_Code()
        {
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control error-aon-blur'])[3]")).SendKeys("MGU012");
        }


        [When(@"User Clicks Link upload the file")]
        public void WhenUserClicksLinkUploadTheFile()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(46), propertytype.XPath);
        }
        [Then(@"User Will redirect to the folder from which file is to be upload")]
        public void ThenUserWillRedirectToTheFolderFromWhichFileIsToBeUpload()
        {
            autoIt.WinActivate("Open");
            CustomControls.Wait();
            autoIt.Send(@"C:\Users\EXP-10009\Desktop");
            CustomControls.Wait();
            autoIt.Send("{ENTER}");
        }
        [Then(@"user Select the Wrong file format and upload")]
        public void ThenUserSelectTheWrongFileFormatAndUpload()
        {
            CustomControls.Wait();
            autoIt.Send("Berkley Excel States Count");
            CustomControls.Wait();
            autoIt.Send("{ENTER}");
        }
        [When(@"User Clicks to submit the file for processing")]
        public void WhenUserClicksToSubmitTheFileForProcessing()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(47), propertytype.XPath);
        }
        [Then(@"User Should not get the successfully file uploaded pop up")]
        public void ThenUserShouldNotGetTheSuccessfullyFileUploadedPopUp()
        {
            try
            {
                CustomControls.Wait();
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//h4)[4]"));
                Assert.AreEqual("Error Bound Busines File Upload", Field.Text);
                IWebElement Field1 = PropertiesCollection.ngdriver.FindElement(By.XPath("(//p/span)[3]"));
                Console.WriteLine("Assertion Pass");
                Console.WriteLine("Reason :" + Field1.Text);
            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);
                


            }
        }
        [When(@"User ClickS on pop up message")]
        public void WhenUserClickSOnPopUpMessage()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(48), propertytype.XPath);
        }

     
        [Then(@"User Should be again on file upload page")]
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














