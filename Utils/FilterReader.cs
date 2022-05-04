﻿using System;
using System.IO;
using System.Xml.Serialization;
using RozetkaPageFactoryParallelWithBuisnessObjAndDeco.DataSource;

namespace RozetkaPageFactoryParallelWithBuisnessObjAndDeco.Utils

{
    class FilterReader
    {
        private Filter filter;

        public FilterReader()
        {
            this.filter = ReadFromXMLFile();
        }

        private Filter ReadFromXMLFile()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Filter));
            try
            {
                string path = Directory.GetCurrentDirectory();
                path = path.Substring(0, path.Length - 17);
                path = Path.Combine(path, @"E:\домашка\EPAM LAB\RozetkaPageFactoryParallelWithBuisnessObjAndDeco\DataSource\Filters.xml");
                using (Stream fStream = File.OpenRead(path))
                {
                    return (Filter)xmlFormat.Deserialize(fStream);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Can`t open filter file");
                return null;
            }
        }


        public static Filters ReadFiltersFromXML()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Filters));
            try
            {
                string path = Directory.GetCurrentDirectory();
                path = path.Substring(0, path.Length - 17);
                path = Path.Combine(path, @"DataSource\Filters.xml");
                using (Stream fStream = File.OpenRead(path))
                {
                    return (Filters)xmlFormat.Deserialize(fStream);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Can`t open filters file");
                return null;
            }
        }
    }
}
