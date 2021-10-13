using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ClassLibrary2.Utilities;
using System.Configuration;
using System;
using ClassLibrary2;

namespace ClassLibrary2.StepDefintions
{
    [Binding]
    public class SugarProductStepDefinitions
    {
        public static IWebDriver _driver;
        private readonly string URL = ConfigurationManager.AppSettings["QA_URL"];

        [Given(@"I am a User")]
        public void GivenIAmAUser()
        {
            //Do Nothing
        }

        [Given(@"I login to Sugar Application")]
        public void GivenILoginToSugarApplication()
        {
            _driver = new ChromeDriver(@"C:\Users\monij\OneDrive\Desktop\Sugar_Automation\ClassLibrary2\Drivers");
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(URL);
            new Class1().Login(_driver);
        }

        [Then(@"I take screenshot")]
        public void ThenITakeScreenshot()
        {
            Utility.Screenshot(_driver, "Login");
        }

        [Then(@"I close Sugar Application")]
        public void ThenICloseSugarApplication()
        {
            _driver.Quit();
        }

    }
}
