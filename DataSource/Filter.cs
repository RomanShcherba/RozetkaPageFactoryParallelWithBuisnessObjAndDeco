﻿using System;

namespace RozetkaPageFactoryParallelWithBuisnessObjAndDeco.DataSource
{
    [Serializable]
    public class Filter
    {
        public string nameProducts { get; set; }
        public string brand { get; set; }
        public int sort { get; set; }
        public int price { get; set; }
    }
}
