using System.Collections.Generic;

namespace MbmStore.Models
{
    public class Customer
    {
        private List<string> phoneNumbers = new List<string>();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        //public string Phonenumber { get; set; }

        public List<string> PhoneNumbers
        {
            get
            {
                return phoneNumbers;
            }
        }

        public Customer(string firstName, string lastName, string address, string zip, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Zip = zip;
            City = city;
        }

        public void addPhone(string phone)
        {
            if (phoneNumbers == null)
            {
                phoneNumbers = new List<string>();
            }
            phoneNumbers.Add(phone);
        }

    }
}