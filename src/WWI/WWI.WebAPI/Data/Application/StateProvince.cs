using System;

namespace WWI.WebAPI.Data.Application
{
    public class StateProvince
    {
        public int StateProvinceID { get; set; }
        public string StateProvinceCode { get; set; }
        public string StateProvinceName { get; set; }
        public string SalesTerritory { get; set; }
        public string Border { get; set; }
        public long LatestRecordedPopulation { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        // Configuring one-to-many relationship with People.
        public int LastEditedBy { get; set; }
        public People People { get; set; }
    }
}