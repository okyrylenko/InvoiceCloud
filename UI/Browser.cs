using InvoiceCloud.UI.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace InvoiceCloud.UI
{
    public class Browser
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public Browser(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        /// <summary>
        /// opens a url
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        public T OpenUrl<T>(string url = "") where T : IPage
        {
            driver.Navigate().GoToUrl($"https://the-internet.herokuapp.com/add_remove_elements/{url}");
            return (T)Activator.CreateInstance(typeof(T), driver, wait);
        }
    }
}

