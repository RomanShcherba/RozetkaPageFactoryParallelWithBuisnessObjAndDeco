using System.Threading;
using OpenQA.Selenium;
using RozetkaPageFactoryParallelWithBuisnessObjAndDeco.Pages;

namespace RozetkaPageFactoryParallelWithBuisnessObjAndDeco.BuisnessObject
{
    class SearchProduct
    {
        public void SearchByKeyword(IWebDriver driver, string Keyword)
        {
            HomePage homePage = new HomePage(driver);

            homePage.SearchByKeyword(Keyword);
        }
    }
}
