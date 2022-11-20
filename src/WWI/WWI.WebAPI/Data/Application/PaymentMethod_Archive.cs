using System;

namespace WWI.WebAPI.Data.Application
{
    public class PaymentMethod_Archive
    {
        public int PaymentMethodID { get; set; }
        public string PaymentMethodName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}