using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;

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
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // без цьої хуйні не працює
            ExcelUtil.PopulateInCollection("./Data.xlsx");

            //Login to Application
            LoginPageObject pageLogin = new LoginPageObject();

            //Щоб перейти на іншу сторінку нам потрібно по-перше створити для неї об'єкт, а подруге - викликати метод що призведе до редіректу
            EAPageObject pageEA = pageLogin.Login(ExcelUtil.ReadData(1,"UserName"), ExcelUtil.ReadData(1, "Password"));

            //Заповнюємо форму інфорю з іксель документа
            pageEA.FillUserForm(ExcelUtil.ReadData(1, "Initial"), ExcelUtil.ReadData(1, "FirstName"), ExcelUtil.ReadData(1,"MiddleName"));


        }

        [TearDown]
        public void CleanUp()
        {
            //driver.Close();
            System.Console.WriteLine("The browser is closed");
        }
    }
}