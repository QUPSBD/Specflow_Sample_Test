using OpenQA.Selenium;
using specflow_demo_bikroy.Utils;
using Specflow_demo_bikroy.Drivers;
using Specflow_demo_bikroy.Utils;
using System;
using TechTalk.SpecFlow;

namespace Specflow_demo_bikroy.Steps
{
    [Binding]
    public class PostAAddSteps : BaseClass
    {
        CommonMethods commonMethods;

        public PostAAddSteps()
        {
            commonMethods = new CommonMethods(driver);
        }

        [Given(@"user can click on post your Ad")]
        public void GivenUserCanClickOnPostYourAd()
        {
            System.Threading.Thread.Sleep(Locators.timeDelay);
            driver.FindElement(By.XPath(Locators.postYourAddXpath)).Click();
        }
        
        [Given(@"user can click Look for something to buy")]
        public void GivenUserCanClickLookForSomethingToBuy()
        {
            System.Threading.Thread.Sleep(Locators.timeDelay);
            driver.FindElement(By.XPath(Locators.lookForSomethingToBuyXpath)).Click();
            System.Threading.Thread.Sleep(Locators.timeDelay);
        }
        
        [When(@"user select category and subcategory")]
        public void WhenUserSelectCategoryAndSubcategory()
        {
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.clickOnElement(Locators.electronicsXpath);
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.clickOnElement(Locators.laptopXpath);
            System.Threading.Thread.Sleep(Locators.timeDelay);
        }
        
        [When(@"user select City and Local area")]
        public void WhenUserSelectCityAndLocalArea()
        {
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.clickOnElement(Locators.rajshahiXpath);
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.clickOnElement(Locators.uposohorXpath);
        }
        
        [Then(@"user can fill the details of product")]
        public void ThenUserCanFillTheDetailsOfProduct()
        {
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.sendText(Locators.titleId, Locators.titleText);
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.sendText(Locators.descripTionXpath, Locators.descriptionText);
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.sendText(Locators.phoneNumberClass, Locators.phoneNumber);
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.clickOnElement(Locators.addNumberClass);
            driver.Quit();
        }

        [Given(@"user can click sell an Item")]
        public void GivenUserCanClickSellAnItem()
        {
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.clickOnElement(Locators.sellItemXpath);
        }

        [Then(@"user can fill the details of product sell")]
        public void ThenUserCanFillTheDetailsOfProductSell()
        {
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.clickOnElement(Locators.usedXpath);
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.clickOnElement(Locators.brandXpath);
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.clickOnElement(Locators.brandXpath);
            commonMethods.sendText(Locators.modelId, "acer-5");
            commonMethods.sendText(Locators.titleId, Locators.titleText);
            System.Threading.Thread.Sleep(Locators.timeDelay);
            commonMethods.sendText(Locators.priceId, "20000");
            System.Threading.Thread.Sleep(Locators.timeDelay);
          //  commonMethods.sendText(Locators.phoneNumberClass, Locators.phoneNumber);
           // System.Threading.Thread.Sleep(Locators.timeDelay);
          //  commonMethods.clickOnElement(Locators.addNumberClass);
            driver.Quit();
        }

    }
}
