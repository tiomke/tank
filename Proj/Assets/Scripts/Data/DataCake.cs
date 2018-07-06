using System;
using System.Collections.Generic;
using CsvHelper;
using CsvHelper.Configuration;

namespace DesignData
{
    public class Cake : IData 
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Path { get; set; }

    }

    public sealed class CakeMap : CsvClassMap<Cake>
    {
        public CakeMap()
        {
            Map(m => m.ID);
            Map(m => m.Name);
            Map(m => m.Price);
            Map(m => m.Path);
        }
    }
}