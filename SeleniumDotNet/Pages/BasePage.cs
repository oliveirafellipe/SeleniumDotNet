using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDotNet.Pages
{
    public class BasePage
    {

        protected IWebDriver browser;

        public BasePage(IWebDriver browser)
        {
            this.browser = browser;
        }

    }
}
