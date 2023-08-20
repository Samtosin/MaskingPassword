using MaskingPassword.Hooks;
using MaskingPassword.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MaskingPassword.StepDefinitions
{
    [Binding]
    public class TestLoginSteps
    {
        public IWebDriver driver = WebHooks.driver;
        TestLoginPage testLoginPage = new TestLoginPage();

        [Given(@"i navigate to website ""([^""]*)""")]
        public void GivenINavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        
        [When(@"i enter username")]
        public void WhenIEnterUsername()
        {
            Thread.Sleep(3000);
            testLoginPage.EnterUserName();
        }


        [When(@"i enter password")]
        public void WhenIEnterPassword()
        {
            Thread.Sleep(3000); 
            testLoginPage.EnterPassword();
        }

        [When(@"i click submit")]
        public void WhenIClickSubmit()
        {
            Thread.Sleep(3000); 
            testLoginPage.ClickSubmit();
        }

        [Then(@"i should login successfully")]
        public void ThenIShouldLoginSuccessfully()
        {
            Thread.Sleep(3000); 
            Assert.IsTrue(testLoginPage.LoginSuccessful());
        }
    }
}
