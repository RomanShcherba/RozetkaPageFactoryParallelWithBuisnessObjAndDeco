using System;
using OpenQA.Selenium;

namespace RozetkaPageFactoryParallelWithBuisnessObjAndDeco.Decorator
{
   public static class Decorator
   {
        public static void Click(this IWebElement element, string nameOfElement)
        {
            element.Click();
            Console.WriteLine("Clicked on {0}.", nameOfElement);
        }

        public static void SendKeys(this IWebElement element, string text, string nameOfElement)
        {
            element.Clear();
            element.SendKeys(text);
            Console.WriteLine("{0} entered in the {1} field.", text, nameOfElement);
        }
   }
}
