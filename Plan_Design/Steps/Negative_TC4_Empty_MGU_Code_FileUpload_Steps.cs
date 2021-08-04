using System;
using System.Collections.Generic;
using AutoItX3Lib;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Plan_Design.Steps
{
    [Binding]
    public class Negative_TC4_Empty_MGU_Code_FileUploadSteps
    {
        int flag;
        SETUP setup = new SETUP();
        AutoItX3 autoIt = new AutoItX3();
     
        [Given(@"User Should be on Home Page -as Display LabeL ""(.*)""")]
        public void GivenUserShouldBeOnHomePage_AsDisplayLabeL(string dashboard)
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
        
        [When(@"User Clicks Search Button")]
        public void WhenUserClicksSearchButton()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(42), propertytype.XPath);
        }
        [Then(@"The List of Search item Will Appear")]
        public void ThenTheListOfSearchItemWillAppear()
        {
            CustomControls.Wait();
            Console.WriteLine("List of drop down items are :");
            ListOfItems.Items();
        }

        [When(@"User Clicks Link- Document Search")]
        public void WhenUserClicksLink_DocumentSearch()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(43), propertytype.XPath);
        }
        [Then(@"User Should be on document search page -as display label Document Search\.")]
        public void ThenUserShouldBeOnDocumentSearchPage_AsDisplayLabelDocumentSearch_()
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
        [When(@"User Clicks Link MGU File Upload\.")]
        public void WhenUserClicksLinkMGUFileUpload_()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(44), propertytype.XPath);
        }
        [Then(@"User Should be on file upload Page\.")]
        public void ThenUserShouldBeOnFileUploadPage_()
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
      
        [When(@"User Clicks Link Upload the File")]
        public void WhenUserClicksLinkUploadTheFile()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(46), propertytype.XPath);
        }
        [Then(@"User Will Redirect to the Folder from which file is to be upload")]
        public void ThenUserWillRedirectToTheFolderFromWhichFileIsToBeUpload()
        {
            autoIt.WinActivate("Open");
            CustomControls.Wait();
            autoIt.Send(@"C:\Users\EXP-10009\Desktop");
            CustomControls.Wait();
            autoIt.Send("{ENTER}");
        }
        [Then(@"user Select the file with Different Name and upload")]
        public void ThenUserSelectTheFileWithDifferentNameAndUpload()
        {
            CustomControls.Wait();
            autoIt.Send("MGU110_05-10-2021 (2)");
            CustomControls.Wait();
            autoIt.Send("{ENTER}");

        }
        [When(@"User Clicks to Submit the file for Processing")]
        public void WhenUserClicksToSubmitTheFileForProcessing()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(47), propertytype.XPath);
            CustomControls.Wait();            
            IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//span[@id='ctl00_cphMain_cntrlUpload_RequiredFieldValidator2'])"));
            Assert.AreEqual("Enter MGU Code", Field.Text);
            Console.WriteLine("Assertion Pass");
            Console.WriteLine("Error Message is :" +Field);
        }
        /*
        [Then(@"User Should not get the Successfully File uploaded pop up")]
        public void ThenUserShouldNotGetTheSuccessfullyFileUploadedPopUp()
        {
            try
            {
                CustomControls.Wait();
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//h4)[4]"));
                Assert.AreEqual("Error Bound Busines File Upload", Field.Text);
                IWebElement Field1 = PropertiesCollection.ngdriver.FindElement(By.XPath("(//p/span)[3]"));
                Console.WriteLine("Assertion Pass");
                Console.WriteLine(Field1.Text);


            }
            catch (Exception e)
            {
                CustomControls.Wait();
                Console.WriteLine(e);


            }
        }

      
        [When(@"User Clicks on pop up Message")]
        public void WhenUserClicksOnPopUpMessage()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(48), propertytype.XPath);
        }
        [Then(@"User Should be Again on File upload page")]
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
        */
    }
}














