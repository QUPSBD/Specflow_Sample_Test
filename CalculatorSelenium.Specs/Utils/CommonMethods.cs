using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Specflow_demo_bikroy.Utils
{
    public class CommonMethods
    {
        public static IWebDriver _driver;

        public CommonMethods(IWebDriver driver) { _driver = driver; }

        public void assertElement(By elementPath, String elementText)
        {
            string text = _driver.FindElement(elementPath).Text;
            Assert.AreEqual(text, elementText);

            Console.WriteLine("Successfully visit " + text);
        }

        public void clickByIndex(String index)
        {

            //_driver.FindElement(By.XPath("//body/div[@id='app-container']/div[@id='app-wrapper']/div[1]/div[3]/div[3]/ul[1]/li[1]/a[1]")).Click();
            //body/div[@id='app-container']/div[@id='app-wrapper']/div[1]/div[3]/div[3]/ul[1]/li[1]/a[1]
            //body/div[@id='app-container']/div[@id='app-wrapper']/div[1]/div[3]/div[3]/ul[1]/li[2]/a[1]
        }

        public void clickOnElement(By element)
        {
            _driver.FindElement(element).Click();
        }

        public void sendText(By field, String text)
        {
            _driver.FindElement(field).SendKeys(text);
        }
    }
}
