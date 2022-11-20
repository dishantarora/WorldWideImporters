using System;

namespace WWI.WebAPI.Data.Application
{
    public class DeliveryMethod_Archive
    {
        public int DeliveryMethodID { get; set; }
        public string DeliveryMethodName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}