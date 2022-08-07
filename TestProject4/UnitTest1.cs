using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject4
{
    public class Tests
    {
       


        [SetUp]
        public void Setup()
        {

            PropertiesCollection.driver = new ChromeDriver();
            
            PropertiesCollection.driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");
            System.Console.WriteLine("URL is opened");
            PropertiesCollection.driver.Manage().Window.Maximize();


        }

        [Test]
        public void Test1()
        {

            //Login to Application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("execute", "automation");

            pageEA.FillUserForm("MR.", "VOVA", "GAY");


        }

        [TearDown]
        public void CleanUp()
        {
            //driver.Close();
            System.Console.WriteLine("The browser is closed");
        }
    }
}