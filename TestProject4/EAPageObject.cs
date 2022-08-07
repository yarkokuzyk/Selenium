using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestProject4
{
    internal class EAPageObject
    {

        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }


        [FindsBy(How = How.XPath, Using = ".//select")]
        public IWebElement ddlTitleID { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='Initial']")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='FirstName']")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='MiddleName']")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@type='button']")]
        public IWebElement btnSave { get; set; }


        public void FillUserForm(string initial, string firstname, string middlename)
        {

            


            txtInitial.EnterText(initial);
            txtFirstName.EnterText(firstname);
            txtMiddleName.EnterText(middlename);
            btnSave.Clicks();
        }


    }
}
