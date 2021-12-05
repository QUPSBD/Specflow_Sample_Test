using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using specflow_demo_bikroy.Utils;
using Specflow_demo_bikroy.Drivers;
using System;
using TechTalk.SpecFlow;

namespace Specflow_demo_bikroy.Steps
{
    [Binding]
    public class LoginSteps : BaseClass
    {
        //public IWebDriver _driver;

        [Given(@"User will go to bikroy home page")]
        public void GivenUserWillGoToBikroyHomePage()
        {
            goToWebPage();
            _driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(Locators.timeDelay);
        }
        
        [Given(@"user go to login form")]
        public void GivenUserGoToLoginForm()
        {
            System.Threading.Thread.Sleep(Locators.timeDelay);
            _driver.FindElement(By.XPath(Locators.signInXpath)).Click();
            System.Threading.Thread.Sleep(Locators.timeDelay);
            _driver.FindElement(By.XPath(Locators.continueWithEmailXpath)).Click();
            System.Threading.Thread.Sleep(Locators.timeDelay);
        }

        [When(@"user fill the login form")]
        public void WhenUserFillTheLoginForm()
        {
            _driver.FindElement(By.Id(Locators.emailId)).SendKeys(Locators.email);
            System.Threading.Thread.Sleep(Locators.timeDelay);
            _driver.FindElement(By.Id(Locators.passwordId)).SendKeys(Locators.password);
            System.Threading.Thread.Sleep(Locators.timeDelay);
        }
        
        [Then(@"user will login to bikroy web")]
        public void ThenUserWillLoginToBikroyWeb()
        {
            _driver.FindElement(By.XPath(Locators.loginXpath)).Click();
            System.Threading.Thread.Sleep(Locators.timeDelay);
            //_driver.Quit();
        }
    }
}
