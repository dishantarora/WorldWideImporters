using System;

namespace WWI.WebAPI.Data.Application
{
    public class DeliveryMethod
    {
        public int DeliveryMethodID { get; set; }
        public string DeliveryMethodName { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        // Configuring one-to-many relationship with People.
        public int LastEditedBy { get; set; }
        public People People { get; set; }
    }
}