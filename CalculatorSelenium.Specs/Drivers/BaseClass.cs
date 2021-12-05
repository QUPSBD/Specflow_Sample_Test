using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using specflow_demo_bikroy.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Specflow_demo_bikroy.Drivers
{
    public class BaseClass
    {
        public static IWebDriver _driver;

        public void goToWebPage()
        {
            _driver = new ChromeDriver();
            _driver.Url = Locators.url;
        }

        public IWebDriver driver = _driver;

    }
}
