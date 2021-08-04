using System;
using System.Collections.Generic;
using AutoItX3Lib;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Plan_Design.Steps
{
    [Binding]
    public class Positive_TC2_MGU_Download_TemplateSteps
    {
        int flag;
        SETUP setup = new SETUP();
        AutoItX3 autoIt = new AutoItX3();
        
        [Given(@"User Should be on Home page-as display label ""(.*)""")]
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
        
        [When(@"User Clicks search")]
        public void WhenUserClicksSearch()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(42), propertytype.XPath);
        }
        [Then(@"The List of search item will appear")]
        public void ThenTheListOfSearchItemWillAppear()
        {
            CustomControls.Wait();
            Console.WriteLine("List of drop down items are :");
            ListOfItems.Items();
        }

        [When(@"User Clicks link Document search")]
        public void WhenUserClicksLinkDocumentSearch()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(43), propertytype.XPath);
        }
        
        [When(@"User Clicks button-MGU File Upload")]
        public void WhenUserClicksButton_MGUFileUpload()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(44), propertytype.XPath);
        }
        
        [When(@"User Enter MGU Code")]
        public void WhenUserEnterMGUCode()
        {
            CustomControls.Wait();
            PropertiesCollection.ngdriver.FindElement(By.XPath("(//input[@class='form-control error-aon-blur'])[3]")).SendKeys("MGU012");
        }
        
        [When(@"user clicks on Download template")]
        public void WhenUserClicksOnDownloadTemplate()
        {
            CustomControls.Wait();
            CustomControls.click(PageObjects.Login_Screen(51), propertytype.XPath);
            try
            {
                CustomControls.Wait();
                IWebElement Field = PropertiesCollection.ngdriver.FindElement(By.XPath("(//span[@class='error'])[4]"));
                Assert.AreEqual("", Field.Text);
                Console.WriteLine("Testcase pass");
            }
            catch (Exception Field)
            {
                Console.WriteLine(Field);
                Console.WriteLine("Testcase Fail");

            }
        }
        
        
    }
}
