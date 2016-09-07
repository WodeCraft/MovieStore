namespace MbmStore.Models
{
    public class Customer
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Phonenumber { get; set; }

        public Customer(string firstName, string lastName, string address, string zip, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Zip = zip;
            City = city;
        }

    }
}