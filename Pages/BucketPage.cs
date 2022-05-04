using OpenQA.Selenium;
using RozetkaPageFactoryParallelWithBuisnessObjAndDeco.Decorator;
using SeleniumExtras.PageObjects;

namespace RozetkaPageFactoryParallelWithBuisnessObjAndDeco.Pages
{
    class BucketPage : BasePage
    {
        public BucketPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this); 
        }

        [FindsBy(How = How.XPath, Using = "//div[@class ='cart-receipt__sum-price']//span[contains(@class,'')]")]
        private IWebElement bucketTotal;

        [FindsBy(How = How.XPath, Using = "//rz-cart//button[contains(@class, 'header__button ng-star-inserted')]")]
        private IWebElement cartButton;

        public void ClickCartButton()
        {
            cartButton.Click("cart button");
        }

        public int getBucketSumm()
        {
            return int.Parse(bucketTotal.Text);
        }

    }
}
