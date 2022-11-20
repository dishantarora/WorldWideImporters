using System;

namespace WWI.WebAPI.Data.Application
{
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int StateProvinceId { get; set; }
        public string Location { get; set; }
        public long LatestRecordedPopulation { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        // Configuring one-to-many relationship with People.
        public int LastEditedBy { get; set; }
        public People People { get; set; }
    }
}