using System;

namespace WWI.WebAPI.Data.Application
{
    public class SystemParameter
    {
        public int SystemParameterID { get; set; }
        public string DeliveryAddressLine1 { get; set; }
        public string DeliveryAddressLine2 { get; set; }
        public int DeliveryCityID { get; set; }
        public string DeliveryPostalCode { get; set; }
        public string DeliveryLocation { get; set; }
        public string PostalAddressLine1 { get; set; }
        public string PostalAddressLine2 { get; set; }
        public int PostalCityID { get; set; }
        public string PostalCode { get; set; }
        public string ApplicationSettings { get; set; }
        public DateTime LastEditedWhen { get; set; }

        // Configuring one-to-many relationship with People.
        public int LastEditedBy { get; set; }
        public People People { get; set; }
    }
}