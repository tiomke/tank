using System;
using System.Collections.Generic;
using CsvHelper;
using CsvHelper.Configuration;

namespace DesignData
{
    public class Cake : IData 
    {
        public int ID { get; set; }
        public string Name;
        public float Price;
        public string Path;

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