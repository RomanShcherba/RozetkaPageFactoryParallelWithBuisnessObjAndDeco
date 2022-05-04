using NUnit.Framework;
using RozetkaPageFactoryParallelWithBuisnessObjAndDeco.BuisnessObject;
using RozetkaPageFactoryParallelWithBuisnessObjAndDeco.DataSource;
using RozetkaPageFactoryParallelWithBuisnessObjAndDeco.Pages;
using RozetkaPageFactoryParallelWithBuisnessObjAndDeco.Utils;

[assembly: LevelOfParallelism(3)]

namespace RozetkaPageFactoryParallelWithBuisnessObjAndDeco.Tests
{
    [TestFixture]

    [Parallelizable(scope: ParallelScope.All)]
    public class BucketVerifyTest : BaseTest
    {
        
        [TestCaseSource(typeof(DataProvider), nameof(DataProvider.TestData))]
        public void ExecuteTest(Filter filter)
        {
            SearchProduct searchProduct = new();
            searchProduct.SearchByKeyword(Driver, filter.nameProducts);
            BuyProduct buyProduct = new();
            buyProduct.ChooseProduct(Driver, filter.brand, filter.sort);
            CheckSumm checkSumm = new();
            int total = checkSumm.CheckSumma(Driver);
            Assert.That(total, Is.LessThan(filter.price));

        }
    }
}
