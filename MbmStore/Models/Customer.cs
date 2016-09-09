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
                int age = calculateAge(value);
                if (age < 0 || age > 120)
                {
                    throw new Exception("Age not accepted");
                }
                else
                {
                    birthDate = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return calculateAge(birthDate);
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

        private int calculateAge(DateTime checkedDate)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - checkedDate.Year;

            if (now.Month < checkedDate.Month
                || (now.Month == checkedDate.Month && now.Day < checkedDate.Day))
            {
                age--;
            }

            return age;
        }

    }
}