using System;
using System.Collections.Generic;

namespace MbmStore.Models
{
    public class Customer
    {
        private List<string> phoneNumbers = new List<string>();
        private DateTime birthDate;

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

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;

                int age = Age;
                if (age < 0 && age > 120)
                {
                    throw new Exception("Age not accepted");
                }
            }
        }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age = now.Year - birthDate.Year;

                if (now.Month < birthDate.Month
                    || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    age--;
                }

                return age;
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