using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using RozetkaPageFactoryParallelWithBuisnessObjAndDeco.Pages;

namespace RozetkaPageFactoryParallelWithBuisnessObjAndDeco.BuisnessObject
{
    class CheckSumm
    {
        public int CheckSumma(IWebDriver driver)
        {
            BucketPage bucketPage = new BucketPage(driver);
            bucketPage.ClickCartButton();
            return bucketPage.getBucketSumm();
        }
    }
}
