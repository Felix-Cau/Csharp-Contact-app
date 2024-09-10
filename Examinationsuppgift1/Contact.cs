using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examinationsuppgift1
{
    public class Contact
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }


        public Contact()
        {
            Name = $"{Messages.propertyErrorMessage}";
            Address = $"{Messages.propertyErrorMessage}";
            PostalCode = $"{Messages.propertyErrorMessage}";
            City = $"{Messages.propertyErrorMessage}";
            PhoneNumber = $"{Messages.propertyErrorMessage}";
            Email = $"{Messages.propertyErrorMessage}";
        }
        public Contact(string name, string address, string postalCode, string city, string phoneNumber, string email)
        {
            Name = name;
            Address = address;
            PostalCode = postalCode;
            City = city;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
