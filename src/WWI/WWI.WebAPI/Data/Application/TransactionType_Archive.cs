using System;

namespace WWI.WebAPI.Data.Application
{
    public class TransactionType_Archive
    {
        public int TransactionTypeID { get; set; }
        public string TransactionTypeName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}