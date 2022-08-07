using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject4
{
    internal class SeleniumSetMethods
    {

        // SendKeys
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);

        }

        //Click Something
        public static void Click(IWebElement element)
        {
         element.Click();
            
        }

        // Selecting a drop down control
        public static void SelectDropDown(IWebElement element, string value)
        {
            
            
               new SelectElement(element).SelectByText(value);
            
        }


    }
}
