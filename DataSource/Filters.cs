using System;
using System.Collections.Generic;

namespace RozetkaPageFactoryParallelWithBuisnessObjAndDeco.DataSource
{
    [Serializable]
    public class Filters
    {
        public List<Filter> FiltersList { get; set; }
        public Filters()
        {
            FiltersList = new List<Filter>();
        }
    }
}
