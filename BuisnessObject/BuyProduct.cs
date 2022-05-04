using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using RozetkaPageFactoryParallelWithBuisnessObjAndDeco.Pages;

namespace RozetkaPageFactoryParallelWithBuisnessObjAndDeco.BuisnessObject
{
    class BuyProduct
    {
        public void ChooseProduct(IWebDriver driver, string searchBrand, int sort)
        {
            SearchResultsPage searchResultsPage = new SearchResultsPage(driver);

            searchResultsPage.filterByBrand(searchBrand);
            searchResultsPage.changeSortingHigh(sort);
            searchResultsPage.BuyFirstProduct();
        }

    }
}
