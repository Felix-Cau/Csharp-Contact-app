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
        private string _firstName;
        private string _lastName;
        private string _address;
        private string _postalCode;
        private string _city;
        private string _phoneNumber;
        private string _email;


        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Address { get => _address; set => _address = value; }
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        public string City { get => _city; set => _city = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string Email { get => _email; set => _email = value; }


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
