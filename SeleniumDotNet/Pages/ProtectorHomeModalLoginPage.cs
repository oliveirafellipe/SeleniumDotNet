using OpenQA.Selenium;

namespace SeleniumDotNet.Pages
{
    class ProtectorHomeModalLoginPage : BasePage
    {

        public ProtectorHomeModalLoginPage(IWebDriver browser) : base(browser) { }


        public ProtectorSeguradoHomePage clickSouSegurado()
        {
            browser.FindElement(By.LinkText("http://staging.argo-protector.com.br/meuprotector"))
                .Click();

            return new ProtectorSeguradoHomePage(browser);
        }

        public ProtectorCorretorHomePage clickSouCorretor()
        {
            browser.FindElement(By.LinkText("http://staging.argo-protector.com.br/corretor"))
                .Click();

            return new ProtectorCorretorHomePage(browser);
        }

    }
}