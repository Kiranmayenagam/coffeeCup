﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCup
{
    public enum Gender
    {
        Female,
        Male
    }
    /// <summary>
    /// This is a employee class where we can entry complete employee details. 
    /// </summary>
    public class Employee
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
        ///employeeid has a private set in which only owner can give the identy to the employee.
        [Key]
        public int EmployeeId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
        public int ContactNo { get; set; }
        public Gender  Gender { get; set; }
        public string Emailid { get; set; }
        public string  Password { get; set; }
        public decimal Salary { get;set; }

        

        public virtual ICollection<Employee> employees { get; set; }
        #endregion
        #region Constructors

        public Employee()
        {
            EmployeeId = ++lastEmployeeId;
        }
        public Employee(string firstName) : this()
        {
            FirstName = firstName;
        }
        public Employee(string firstName,string lastName) : this(firstName)
        {
            LastName = lastName;
        }
        public Employee(string firstName,string lastName,string address) : this(lastName)
        {
            Address = address;
        }
        public Employee(string firstName,string lastName,string address,string city) :this(address)
        {
            City = city;
        }
        public Employee(int pincode) :this()
        {
            Pincode = pincode;
        }
        public Employee(string firstName, string lastName, string address, string city,int pincode,int contactNo) : this(pincode)
        {
            ContactNo = contactNo;
        }
        public Employee(string firstName, string lastName, string address, string city, int pincode, int contactNo,Gender gender) : this(contactNo)
        {
            Gender = gender;
        }
        public Employee(string firstName, string lastName, string address, string city, int pincode, int contactNo,Gender gender,string emailId) : this()
        {
            Emailid = emailId;
        }
        public Employee(string firstName,string lastName,string address,string city,int pincode,int contactNo,Gender gender,string emailid,string password) :this(emailid)
        {
            Password = password;
        }
        /// <summary>
        /// employee
        /// </summary>
        /// </param>
        /// <param name="firstName">
        /// First Name
        /// </param>
        /// <param name="lastName">
        /// Last Name
        /// </param>
        /// <param name="address">
        /// Employee Address
        /// </param>
        /// <param name="city">
        /// Employee City
        /// </param>
        /// <param name="pincode">
        /// PinCode
        /// </param>
        /// <param name="contactNo">
        /// Contact Number
        /// </param>
        /// <param name="gender">
        /// Gender
        /// </param>
        /// <param name="emailid">
        /// Email Id of employee
        /// </param>
        /// <param name="salary">
        /// Salary of Employee
        /// </param>
        public Employee(string firstName, string lastName, string address, string city, int pincode, int contactNo,Gender gender,string emailid,string password,decimal salary) : this(password)
        {
            Salary = salary;
        }
       #endregion
        #region Methods
        public string login(string emailid,string password)
        {
            
            Emailid = emailid;
            Password = password;
            return "login Correct";
        }
        public void logout ()
        {
            Console.Write("See you soon");
        }
        public string Update(string firstName,string lastName,string address,string city,int pincode,int contactNo,Gender gender,string emailid,string password,decimal salary)
        {
            
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            Pincode = pincode;
            ContactNo = contactNo;
            Gender = gender;
            Emailid = emailid;
            Password = password;
            Salary = salary;
            return "Employee info update";
         }
        public void Delete(int employeeid)
        {
            EmployeeId = employeeid;
        }

        #endregion
    }

}
