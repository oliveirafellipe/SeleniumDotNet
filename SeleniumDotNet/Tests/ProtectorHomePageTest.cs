using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumDotNet.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDotNet.Tests
{
       public class ProtectorHomePageTest : LoginSegurado

    {
               
        public void Before()
        {
            LoginSegurado loginSegurado = new LoginSegurado();
            loginSegurado.Init();
        }

        [Test]
        public void ValidaLogin()
        {
            SetUp setup = new SetUp();
            setup.getBrowser();

            /*IWebDriver browser = setup.getBrowser();


            ProtectorHomePage home = new ProtectorHomePage(browser);
            ProtectorHomeModalLoginPage modalHome = new ProtectorHomeModalLoginPage(browser);
            ProtectorSeguradoHomePage seguradoHome = new ProtectorSeguradoHomePage(browser);
            home.ClickLogin();
            modalHome.clickSouSegurado();
            seguradoHome.typeUsername("hardwsystem@gmail.com.trin.ca");
            seguradoHome.typePassword("1234");
            seguradoHome.clickLogin();*/

        }

    }
}
