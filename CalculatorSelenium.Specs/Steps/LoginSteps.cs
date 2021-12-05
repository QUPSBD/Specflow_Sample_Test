using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using specflow_demo_bikroy.Utils;
using System;
using TechTalk.SpecFlow;

namespace Specflow_demo_bikroy.Steps
{
    [Binding]
    public class LoginSteps
    {
        public IWebDriver _driver;

        [Given(@"User will go to bikroy home page")]
        public void GivenUserWillGoToBikroyHomePage()
        {
            _driver = new ChromeDriver();
            _driver.Url = Locators.url;
            _driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(Locators.timeDelay);
        }
        
        [Given(@"user go to login form")]
        public void GivenUserGoToLoginForm()
        {
            
        }
        
        [When(@"user fill the login form")]
        public void WhenUserFillTheLoginForm()
        {
            
        }
        
        [Then(@"user will login to bikroy web")]
        public void ThenUserWillLoginToBikroyWeb()
        {
            
        }
    }
}
