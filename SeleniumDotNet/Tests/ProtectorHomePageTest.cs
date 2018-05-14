using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumDotNet.Helpers;
using SeleniumDotNet.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDotNet.Tests
{
    public class ProtectorHomePageTest : LoginSegurado

    {
        IWebDriver browser;

        [SetUp]
        public void Before()
        {
            SetUp setup = new SetUp();
            Common common = new Common();

            browser = setup.getBrowser();
            browser = common.doLoginSegurado(this.browser, "hardwsystem@gmail.com.trin.ca", "1234");

            /* ProtectorHomePage home = new ProtectorHomePage(browser);
             ProtectorHomeModalLoginPage modalHome = new ProtectorHomeModalLoginPage(browser);
             ProtectorSeguradoHomePage seguradoHome = new ProtectorSeguradoHomePage(browser);
             home.ClickLogin();
             modalHome.clickSouSegurado();
             seguradoHome.clickPreLogin();
             seguradoHome.typeUsername("hardwsystem@gmail.com.trin.ca");
             seguradoHome.typePassword("1234");
             seguradoHome.clickLogin();*/
        }

        [Test]
        public void ValidaLogin()
        {
            
            string title = browser.Title;
            Assert.AreEqual("Protector | Meu Protector", title);

        }

    }
}
