using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Plan_Design.Steps
{ 

    enum propertytype

{
    Model,
    Repeater,
    Id,
    Name,
    CssSelector,
    Class,
    XPath,
    LinkText
}

class PropertiesCollection
{


        //Auto implemented property


        public static IWebDriver ngdriver { get; set; }

        
    }
    
}