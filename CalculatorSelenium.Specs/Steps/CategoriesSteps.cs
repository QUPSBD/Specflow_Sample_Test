using Specflow_demo_bikroy.Drivers;
using Specflow_demo_bikroy.Utils;
using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using specflow_demo_bikroy.Utils;

namespace Specflow_demo_bikroy.Steps
{
    [Binding]
    public class CategoriesSteps : BaseClass
    {
        CommonMethods commonMethods;
        public CategoriesSteps()
        {
            commonMethods = new CommonMethods(driver);
        }

        [When(@"User go to any page from categories")]
        public void WhenUserGoToAnyPageFromCategories()
        {
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.clickByIndex("1");
            System.Threading.Thread.Sleep(Locators.timeDelay);
        }
        
        [When(@"verify that page")]
        public void WhenVerifyThatPage()
        {
            
        }
    }
}
