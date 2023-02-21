using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace InvoiceCloud.UI
{
    public class BaseComponent:Browser,IBaseComponent
    {
        public BaseComponent(IWebDriver driver, WebDriverWait wait):base(driver,wait)
        {

        }


        /// <summary>
        /// locate element by css
        /// </summary>
        /// <param name="css"></param>
        /// <returns></returns>
        public By LocateElementByCSS(string css) => By.CssSelector(css);


        /// <summary>
        /// find element 
        /// </summary>
        /// <param name="by"></param>
        /// <returns></returns>
        public IWebElement FindElement(By by) => this.driver.FindElement(by);

        /// <summary>
        /// clicks on the element
        /// </summary>
        /// <param name="locator"></param>
        /// <returns></returns>
        public BaseComponent ClickElement(By locator)
        {
            FindElement(locator).Click();
            return this;
        }

        /// <summary>
        /// returns multiple elements
        /// </summary>
        /// <param name="by"></param>
        /// <returns></returns>
        public IList<IWebElement> FindElements(By by) => driver.FindElements(by);
    }
}

