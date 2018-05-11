using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumDotNet.Pages;
using System;

namespace SeleniumDotNet
{
    class SetUp
    {
        
        static void Main()
        {
            SetUp setup = new SetUp();
            IWebDriver browser = setup.getBrowser();


            ProtectorHomePage home = new ProtectorHomePage(browser);
            ProtectorHomeModalLoginPage modalHome = new ProtectorHomeModalLoginPage(browser);
            ProtectorSeguradoHomePage seguradoHome = new ProtectorSeguradoHomePage(browser);
            home.ClickLogin();
            modalHome.clickSouSegurado();
            seguradoHome.typeUsername("hardwsystem@gmail.com.trin.ca");
            seguradoHome.typePassword("1234");
            seguradoHome.clickLogin();


        }

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
