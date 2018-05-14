using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumDotNet.Pages;
using System;

namespace SeleniumDotNet
{
    public class SetUp
    {
        public IWebDriver getBrowser()
        {
            IWebDriver browser = new ChromeDriver("C:\\Selenium\\ChromeDriver\\");

            browser.Navigate().GoToUrl("http://staging.argo-protector.com.br");
            browser.Manage().Window.Maximize();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //browser.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);

            return browser;
        }
    }   
}
