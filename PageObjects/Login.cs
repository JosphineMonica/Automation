using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace ClassLibrary2
{
    public class Class1
    {
        public void Login(IWebDriver _driver)
        {
            _driver.FindElement(By.XPath("//input[@id='email-or-username-field']")).SendKeys("moni.josphine@gmail.com");
            _driver.FindElement(By.XPath("//input[@id='password-field']")).SendKeys("Sugar@123456789");
            _driver.FindElement(By.XPath("//*[text()= 'Log in']")).Click();
            Console.WriteLine("I successfully logged in to Sugar Application");
        }
    }
}
