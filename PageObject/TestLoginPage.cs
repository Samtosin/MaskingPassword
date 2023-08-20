using MaskingPassword.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskingPassword.PageObject
{
    public class TestLoginPage
    {
        public IWebDriver driver;

        public TestLoginPage()
        {
            driver = WebHooks.driver;
        }
        private By user = By.XPath("//*[@id=\"username\"]");
        private By pword = By.XPath("//*[@id=\"password\"]");
        private By submit = By.XPath("//*[@id=\"submit\"]");
        
        public void EnterUserName()
        {
            string username = Environment.GetEnvironmentVariable("Username1");
            driver.FindElement(user).SendKeys(username);
        }
        public void EnterPassword()
        {
            //driver.FindElement(pword).Click();
            string password = Environment.GetEnvironmentVariable("Pword");
            driver.FindElement(pword).SendKeys(password);
        }

        
        public void ClickSubmit()
        {
            driver.FindElement(submit).Click();
        }

        public bool LoginSuccessful()
        {
            return driver.Url.Contains("https://practicetestautomation.com/logged-in-successfully/");
        }
    }
}
