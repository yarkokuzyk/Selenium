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
        public static void EnterText(string element, string value, string type)
        {
            if (type == "XPath")
            {
                PropertiesCollection.driver.FindElement(By.XPath(element)).SendKeys(value);
            }
        }

        //Click Something
        public static void Click(string element, string type)
        {
            if (type == "XPath")
            {
                PropertiesCollection.driver.FindElement(By.XPath(element)).Click();
            }
            
        }

        // Selecting a drop down control
        public static void SelectDropDown(string element, string value, string type)
        {
            
            if (type == "XPath")
            {
               new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(element))).SelectByText(value);
            }
        }


    }
}
