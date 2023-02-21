using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace InvoiceCloud.UI.Pages
{
    public class AddRemoveElementsPage : BaseComponent, IPage
    {
        public AddRemoveElementsPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {

        }

        private By btnAddElement { get { return LocateElementByCSS(".example>button"); } }
        private By btnDelete { get { return LocateElementByCSS("#elements>button"); } }

        public int DeleteElementsCount { get { return GetDeleteElements().Count; } }


        public AddRemoveElementsPage ClickAddElementButton(int amount)
        {
            for(var i = 0; i < amount; i++)
            {
                ClickAddElementButton();
            }
            
            return this;
        }

        public AddRemoveElementsPage ClickAddElementButton()
        {
            ClickElement(btnAddElement);
            return this;
        }



        private IList<IWebElement> GetDeleteElements() => FindElements(btnDelete);
    }
}

