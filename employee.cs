using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCup
{
    /// <summary>
    /// This is a employee class where we can entry complete employee details. 
    /// </summary>
    class employee
    {
        /// <summary>
        /// Here we created a variable for lastemployeeid so that very new employee will get a new id number. 
        /// </summary>
        #region Variables
        private static int lastEmployeeId = 0123;
        #endregion
        /// <summary>
        /// from here we are going to write the properties.
        /// </summary>
        #region properties
        ///employeeid has a private set in which only owner can give set the id.
        public int EmployeeId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
        public int ContactNo { get; set; }
        public string Gender { get; set; }
        public string Emailid { get; set; }
        public int DataOfJoin { get; set; }
        public int Salary { get;set; }
        #endregion
        #region Constructors
        public employee()
        {
            EmployeeId = ++lastEmployeeId;
        }
        public employee(string firstName) : this()
        {
            FirstName = firstName;
        }
        public employee(string firstName,string lastName) : this(firstName)
        {
            LastName = lastName;
        }
        public employee(string firstName,string lastName,string address) : this(lastName)
        {
            Address = address;
        }
        public employee(string firstName,string lastName,string address,string city) :this(address)
        {
            City = city;
        }
        public employee(int pincode) 
        {
            Pincode = pincode;
        }
        public employee(string firstName, string lastName, string address, string city,int pincode,int contactNo) : this(pincode)
        {
            ContactNo = contactNo;
        }
        public employee(string firstName, string lastName, string address, string city, int pincode, int contactNo,string gender) : this(contactNo)
        {
            Gender = gender;
        }
        public employee(string firstName, string lastName, string address, string city, int pincode, int contactNo,string gender,string emailId) : this(gender)
        {
            Emailid = emailId;
        }
        public employee(string firstName, string lastName, string address, string city, int pincode, int contactNo,string gender,string emailid,int dataOfjoin) : this(emailid)
        {
            DataOfJoin = dataOfjoin;

        }
        public employee(string firstName, string lastName, string address, string city, int pincode, int contactNo,string gender,string emailid,int dataOfjoin,int salary) : this(dataOfjoin)
        {
            Salary = salary;
        }
            #endregion
        }

}
