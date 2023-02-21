using System;
using OpenQA.Selenium;

namespace InvoiceCloud.UI
{
	public interface IBaseComponent
	{

        public By LocateElementByCSS(string css);

        public IWebElement FindElement(By by);

        public BaseComponent ClickElement(By locator);

        public IList<IWebElement> FindElements(By by);
    }
}

