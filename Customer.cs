using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCup
{

    class Customer
    {
        #region properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public int PhoneNumber { get; set; }
        #endregion
        #region Construction
        public Customer()
        {
            FirstName = FirstName;
        }
        public Customer(string lastName) : this()
        {
            LastName = lastName;
        }
        public Customer(string firstName,string lastName,string emailAddress) : this(lastName)
        {
            EmailAddress = emailAddress;
        }
        public Customer(string firsName,string lastName,string emailAddress,string userName) : this(emailAddress)
            {
            UserName = UserName;
        }
        public Customer(string firstName,string lastName,string emailAddress,string userName,string password) :this(userName)
        {
            Password = password;
        }
        public Customer(string firstName, string lastName, string emailAddress, string userName, string password,string address) : this(password)
        {
            Address = address;
        }
        public Customer(string firstName, string lastName, string emailAddress, string userName, string password, string address, string city) : this(address)
        {
            City = city;
        }
        public Customer(string firstName, string lastName, string emailAddress, string userName, string password,string address,string city,string state) : this(city)
        {
            State = State;
        }
        public Customer(int postalCode) 
        {
            PostalCode = postalCode;
        }
        public Customer(string firstName, string lastName, string emailAddress, string userName, string password, string address, string city, string state, int postalCode, string country) : this(postalCode)
        {
            Country = Country;
        }
        public Customer(string firstName, string lastName, string emailAddress, string userName, string password,string address,string city,string state,int postalCode,string country,int phoneNumber) : this(country)
         {
            PhoneNumber = phoneNumber;
        }

        #endregion
    }
}
    
    


