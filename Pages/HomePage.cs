using OpenQA.Selenium;
using RozetkaPageFactoryParallelWithBuisnessObjAndDeco.Decorator;
using SeleniumExtras.PageObjects;

namespace RozetkaPageFactoryParallelWithBuisnessObjAndDeco.Pages
{
    class HomePage : BasePage

    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@class='search-form__input ng-untouched ng-pristine ng-valid']")]
        private readonly IWebElement searchInput;
            
        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'button button_color_green')]")]
        private readonly IWebElement searchButton;

        public void SearchByKeyword(string nameProducts)
        {
            searchInput.SendKeys(nameProducts, "search input");
            searchButton.Click("search button");
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(30);
        }

    }
}
