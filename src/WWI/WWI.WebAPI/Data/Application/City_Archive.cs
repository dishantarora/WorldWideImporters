using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WWI.WebAPI.Data.Application
{
    public class City_Archive
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int StateProvinceId { get; set; }
        public string Location { get; set; }
        public long LatestRecordedPopulation { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}