using OpenQA.Selenium;

namespace SeleniumDotNet.Pages
{
    public class ProtectorSeguradoHomePage : BasePage
    {
        public ProtectorSeguradoHomePage(IWebDriver browser) : base(browser) { }


        public ProtectorSeguradoHomePage clickPreLogin()
        {
            browser.FindElement(By.CssSelector("#form1 > div.ctn-main > div.grp-presentation.wdt-lmt > div.menu-login > span.btn-login"))
                .Click();

            return this;
        }

        public ProtectorSeguradoHomePage typeUsername(string username)
        {
            browser.FindElement(By.Id("ContentPlaceHolder1_txtLogin2"))
                .SendKeys(username);

            return this;
        }

        public ProtectorSeguradoHomePage typePassword(string pass)
        {
            browser.FindElement(By.Id("ContentPlaceHolder1_txtPass2"))
                .SendKeys(pass);

            return this;
        }

        public ProtectorSeguradoHomePage clickLogin()
        {
            browser.FindElement(By.Id("ContentPlaceHolder1_btnLogin"))
                .Click();

            return this;
        }
    }
}