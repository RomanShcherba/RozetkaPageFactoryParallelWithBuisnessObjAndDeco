using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RozetkaPageFactoryParallelWithBuisnessObjAndDeco.Decorator;
using SeleniumExtras.PageObjects;

namespace RozetkaPageFactoryParallelWithBuisnessObjAndDeco.Pages
{
    class SearchResultsPage : BasePage
    {

        public SearchResultsPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@data-filter-name='producer']//input")]
        private IWebElement brandSearch;

        [FindsBy(How = How.XPath, Using = "//div[@data-filter-name='producer']//a[1]")]
        private IWebElement brandCheckbox;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'buy-button')]")]
        private IWebElement firstProduct;

        [FindsBy(How = How.CssSelector, Using = "select[class*='select']")]
        IWebElement elementSort;
        SelectElement SortHighDropdown
        {
            get { return new SelectElement(elementSort); }
        }

        public void filterByBrand(string filter)
        {
            Thread.Sleep(3500);
            brandSearch.SendKeys(filter, "brand search");
            Thread.Sleep(3500);
            brandCheckbox.Click("brand chekbox");
        }
        public void changeSortingHigh(int sort)
        {
            SortHighDropdown.SelectByIndex(sort);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }


        public void BuyFirstProduct()
        {
            Thread.Sleep(3500);
            firstProduct.Click("buy button");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
    }
}
