using OpenQA.Selenium;
using SeleniumDotNet.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDotNet.Helpers
{
    public class Common
    {
        public IWebDriver doLoginSegurado(IWebDriver browser, string username, string pass)
        {
            ProtectorHomePage home = new ProtectorHomePage(browser);
            ProtectorHomeModalLoginPage modalHome = new ProtectorHomeModalLoginPage(browser);
            ProtectorSeguradoHomePage seguradoHome = new ProtectorSeguradoHomePage(browser);
            home.ClickLogin();
            modalHome.clickSouSegurado();
            seguradoHome.clickPreLogin();
            seguradoHome.typeUsername("hardwsystem@gmail.com.trin.ca");
            seguradoHome.typePassword("1234");
            seguradoHome.clickLogin();

            return browser;
        }
    }
}
