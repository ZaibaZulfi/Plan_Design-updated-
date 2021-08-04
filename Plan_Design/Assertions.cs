 
using System;
using System.Configuration;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using System.IO;
using OpenQA.Selenium.Support.UI;
using ProtractorTestAdapter;
using NUnit.Framework;

namespace Plan_Design.Steps
{
    class Assertions
    {


        public static void assertionequals(string expectedresult, string actualresult)

        {
            Assert.AreEqual(actualresult, expectedresult, "strings are not equal");
        }
    }
}
