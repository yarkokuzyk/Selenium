using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject4
{
    internal class LoginPageObject
    {

        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = ".//input[@name='UserName']")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='Password']")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='Login']")]
        public IWebElement btnLogin { get; set; }

        public EAPageObject Login(string userName, string password)
        {
            //UserName
            txtUserName.EnterText(userName);
            //password
            txtPassword.EnterText(password);
            //Click button
            btnLogin.Clicks();

            //Return the page object
            return new EAPageObject();
        }




    }
}
