using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject4
{
    internal class SeleniumGetMethods
    {
        public static string GetText(string element, string type)
        {
            if (type == "XPath")
            {
                return PropertiesCollection.driver.FindElement(By.XPath(element)).GetAttribute("value");
            }
            else return String.Empty;
        }

        public static string GetTextFromDDL(string element, string type)
        {
            if (type == "XPath")
            {
                return new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            else return String.Empty;
        }

    }
}
