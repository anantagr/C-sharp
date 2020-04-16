using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClasses
{
    public class Vendor
    {
        // enum: keyword enumerative type: list of constants that you can give to variables
        public enum PreferedContact { Email, Telephone, None };

        //public properties

        public string           CompanyName;
        public string           PhoneNumber;
        public string           EmailAddress;
        public PreferedContact ContactMethod;


        public Vendor(string companyName, string phoneNumber, string emailAddress, PreferedContact method) 
        // Constructor 1

        {
            CompanyName     = companyName;
            PhoneNumber     = phoneNumber;
            EmailAddress    = emailAddress;
            ContactMethod   = method;
        }

        public Vendor(string companyName)   
        // Constructor 2
        {
            CompanyName = companyName;
            PhoneNumber = "";
            EmailAddress = "";
            ContactMethod = PreferedContact.None;
        }

        public string GetPreferedContact()          // Public Method
        {
            switch (ContactMethod)
            {
                case PreferedContact.Email:
                    return (EmailAddress);

                case PreferedContact.Telephone:
                    return (PhoneNumber);

                case PreferedContact.None:
                    return ("Unknown");

                default:
                    throw new Exception("Unknown value of Prefered Contact type");
            }
        }
    }
}
