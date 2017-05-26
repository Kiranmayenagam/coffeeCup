using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCup
{
    /// <summary>
    /// here we enter the details of Customer and can start to login id by entering username and password.
    /// </summary>

    public class Customer
    {
        #region properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set;}
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PinCode{ get; set; }
        public string Country { get; set; }
        public int PhoneNumber { get; set; }

        public virtual ICollection<Customer> customers { get; set; }
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
        public Customer(int pinCode) : this()
        {
            PinCode = pinCode;
        }
        public Customer(string firstName, string lastName, string emailAddress, string userName, string password, string address, string city, string state, int pinCode, string country) : this(pinCode)
        {
            Country = Country;
        }
        public Customer(string firstName, string lastName, string emailAddress, string userName, string password,string address,string city,string state,int pinCode,string country,int phoneNumber) : this(country)
         {
            PhoneNumber = phoneNumber;
        }
        #endregion
        #region Methods
        /// <summary>
        ///In this method you can update the entered information of a Customer.
        /// </summary>
        /// <param name="firstName"> enter firstname</param>
        /// <param name="lastName">lastname</param>
        /// <param name="emailAddress">emailaddress</param>
        /// <param name="userName">username</param>
        /// <param name="password">password</param>
        /// <param name="address">address</param>
        /// <param name="city">city</param>
        /// <param name="state">state</param>
        /// <param name="pincode">pincode</param>
        /// <param name="country">country</param>
        /// <param name="phoneNumber">phonenumber</param>
        /// <returns>after the complete details entered by customer it will update info.</returns>
        public string Update(string firstName,string lastName,string emailAddress,string userName,string password,string address,string city,string state,int pincode,string country,int phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            UserName = userName;
            Password = password;
            Address = address;
            City = city;
            State = state;
            PinCode = pincode;
            Country = country;
            PhoneNumber = phoneNumber;
            return "Customer info updated";

        }
        /// <summary>
        /// this method is used to detele the updated account by using the username.
        /// </summary>
        /// <param name="userName">Username used to detele the account</param>
        public void Delete(string userName)
        {
            UserName = userName;
        }
        /// <summary>
        /// when a old customer want to enter again login method is used.
        /// </summary>
        /// <param name="userName">here the usernameis used to login </param>
        /// <param name="password"> here the password is also used to login</param>
        /// <returns>if both username and password entered by the user are correct it prints login correct.</returns>
        public string Login(string userName,string password)
        {
            UserName = userName;
            Password = password;
            return "Login Correct";
        }
        public void logout()
        {
            Console.Write("Thank You For Visiting");
        }
        

        #endregion
    }
}
    
    


