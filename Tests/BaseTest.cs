using AutoFixture;
using InvoiceCloud.UI;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace InvoiceCloud.Tests
{
    public class BaseTest<TWebDriver>
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        protected Fixture fixture;
        protected IBrowser browser;

        [SetUp]
        public void SetUp()
        {
            this.Setdriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            fixture = new Fixture();
            browser = new Browser(driver, wait);
        }

        [TearDown]
        public void TearDown()
        {
            if (!TestContext.CurrentContext.Result.Outcome.Status.Equals(ResultState.Success))
            {
                //take screenshot, capture browser console errors, etc
            }
            driver.Quit();
        }

        private void Setdriver()
        {

            switch (typeof(TWebDriver).Name)
            {

                case "FirefoxDriver":
                    driver = new FirefoxDriver(); //different FireFoxOptions can be inserted
                    driver.Manage().Window.Maximize();
                    break;
                //more browsers can be returned if needed
                default:
                    driver = new ChromeDriver(); //different ChromeOptions can be inserted
                    driver.Manage().Window.Maximize();
                    break;
            }

        }

    }
}

