using System.Collections.Generic;
using RozetkaPageFactoryParallelWithBuisnessObjAndDeco.DataSource;


namespace RozetkaPageFactoryParallelWithBuisnessObjAndDeco.Utils

{
    public class DataProvider
    {
        public static IEnumerable<Filter> TestData()
        {

            Filters filters = FilterReader.ReadFiltersFromXML(); 
            System.Console.WriteLine("filters:"+filters.ToString());
            for (int i = 0; i < filters.FiltersList.Count; i++)
            {
                yield return filters.FiltersList[i];
            }
        }

    }
}
