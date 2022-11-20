using System;
using System.Collections.Generic;

namespace WWI.WebAPI.Data.Application
{
    public class People
    {
        public int PersonID { get; set; }
        public string FullName { get; set; }
        public string PreferredName { get; set; }
        public string SearchName { get; set; }
        public bool IsPermittedToLogon { get; set; }
        public string LogonName { get; set; }
        public bool IsExternalLogonProvider { get; set; }
        public string HashedPassword { get; set; }
        public bool IsSystemUser { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsSalesPerson { get; set; }
        public string UserPreferences { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Photo { get; set; }
        public string CustomFields { get; set; }
        public string OtherLanguages { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        // Configuring one-to-many relationship with City.
        public virtual ICollection<City> Cities { get; set; }

        // Configuring one-to-many relationship with Country.
        public virtual ICollection<Country> Countries { get; set; }

        // Configuring one-to-many relationship with DeliveryMethod.
        public virtual ICollection<DeliveryMethod> DeliveryMethods { get; set; }

        // Configuring one-to-many relationship with PaymentMethod.
        public virtual ICollection<PaymentMethod> PaymentMethods { get; set; }

        // Configuring one-to-many relationship with StateProvince.
        public virtual ICollection<StateProvince> StateProvinces { get; set; }

        // Configuring one-to-many relationship with TransactionType.
        public virtual ICollection<TransactionType> TransactionTypes { get; set; }

        // Configuring one-to-many relationship with SystemParameters.
        public ICollection<SystemParameter> SystemParameters { get; set; }
    }
}