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
        private string firstName;
        private string lastName;
        private string address;
        private string postalCode;
        private string city;
        private string phoneNumber;
        private string email;


        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string City { get => city; set => city = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }


        public Contact()
        {
            FirstName = $"{Messages.propertyErrorMessage}";
            LastName = $"{Messages.propertyErrorMessage}";
            Address = $"{Messages.propertyErrorMessage}";
            PostalCode = $"{Messages.propertyErrorMessage}";
            City = $"{Messages.propertyErrorMessage}";
            PhoneNumber = $"{Messages.propertyErrorMessage}";
            Email = $"{Messages.propertyErrorMessage}";
        }
        public Contact(string firstName, string lastName, string address, string postalCode, string city, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PostalCode = postalCode;
            City = city;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
