using OpenQA.Selenium;
using specflow_demo_bikroy.Utils;
using Specflow_demo_bikroy.Drivers;
using Specflow_demo_bikroy.Utils;
using System;
using TechTalk.SpecFlow;

namespace Specflow_demo_bikroy.Steps
{

    [Binding]
    public class MyAccountSteps : BaseClass
    {
        CommonMethods commonMethods;
        public MyAccountSteps()
        {
            commonMethods = new CommonMethods(driver);
        }

        [When(@"User can go to My Account page")]
        public void WhenUserCanGoToMyAccountPage()
        {
            driver.FindElement(By.XPath(Locators.myAccountXpath)).Click();
        }
        
        [When(@"user will visit all the tab and verify")]
        public void WhenUserWillVisitAllTheTabAndVerify()
        {
            
            commonMethods.assertElement(Locators.accountTxt, Locators.accountText);
            System.Threading.Thread.Sleep(Locators.timeDelay);
            driver.FindElement(By.XPath(Locators.myMembershipXpath)).Click();
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.assertElement(Locators.myMembershipValidateXpath, Locators.myMembershipText);
            System.Threading.Thread.Sleep(Locators.timeDelay);
            driver.FindElement(By.XPath(Locators.favoritesXpath)).Click();
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.assertElement(Locators.favoritesvalidateXpath, Locators.favoritesText);
            System.Threading.Thread.Sleep(Locators.timeDelay);
            driver.FindElement(By.XPath(Locators.settingXpath)).Click();
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.assertElement(Locators.settingValidateXpath, Locators.settingText);
            System.Threading.Thread.Sleep(Locators.timeDelay);
        }
        
        [Then(@"User go back to home page")]
        public void ThenUserGoBackToHomePage()
        {
            driver.FindElement(By.XPath(Locators.homepageClass)).Click();
            driver.Quit();
        }

        [When(@"user will visit and verify all tab from job section")]
        public void WhenUserWillVisitAndVerifyAllTabFromJobSection()
        {
            driver.FindElement(By.XPath(Locators.myProfileXpath)).Click();
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.assertElement(Locators.myProfileValidateXPath, Locators.myProfileText);
            System.Threading.Thread.Sleep(Locators.timeDelay);
            driver.FindElement(By.XPath(Locators.myaccountJobsXpath)).Click();
            System.Threading.Thread.Sleep(Locators.timeDelay);
            driver.FindElement(By.XPath(Locators.profileDatabaseXpath)).Click();
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.assertElement(Locators.profileDatabaseValidateXpath, Locators.profileDatabaseText);
            System.Threading.Thread.Sleep(Locators.timeDelay);
            driver.FindElement(By.XPath(Locators.myaccountJobsXpath)).Click();

        }

    }
}
