using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDotNet.Pages
{
    public class LoginSegurado
    {
        protected IWebDriver browser;

        public void Init()
        {
            SetUp setUp = new SetUp();
            browser = setUp.getBrowser();


            Login();
        }
        public ProtectorSeguradoHomePage Login()
        {
            ProtectorHomePage home = new ProtectorHomePage(browser);
            ProtectorHomeModalLoginPage modalHome = new ProtectorHomeModalLoginPage(browser);
            ProtectorSeguradoHomePage seguradoHome = new ProtectorSeguradoHomePage(browser);
            home.ClickLogin();
            modalHome.clickSouSegurado();
            seguradoHome.typeUsername("hardwsystem@gmail.com.trin.ca");
            seguradoHome.typePassword("1234");
            seguradoHome.clickLogin();

            return new ProtectorSeguradoHomePage(browser);
        }
    }
}
