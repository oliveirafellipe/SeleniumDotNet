using OpenQA.Selenium;

namespace SeleniumDotNet.Pages
{
    class ProtectorHomePage : BasePage
    {
        public ProtectorHomePage(IWebDriver browser) : base(browser) { }

        public void ClickLogin()
        {
            browser.FindElement(By.Id("link-login"))
            .Click();
        }


    }
}