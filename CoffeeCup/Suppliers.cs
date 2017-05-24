using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCup
{
    class Suppliers
    {
        #region Variables
        private static int lastSupplierId = 0;
        #endregion
        #region Properties
        [Key]
        public int SupplierId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PinCode { get; set; }
        public string  EmailId { get; set; }
        public int  ContactNo { get; set; }
        public string SupplierOffice { get; set; }
        #endregion
        #region Construction
        public Suppliers()
        {
            SupplierId = ++lastSupplierId;
        }
        public Suppliers(string firstName) :this()
        {
            FirstName = firstName;

        }
        public Suppliers(string firstName,string lastName) : this(firstName)
        {
            LastName = lastName;
        }
        public Suppliers(string firstName,string lastName,string address) : this(lastName)
        {
            Address = address;
        }
        public Suppliers(string firstName,string lastName,string address,string city) :this(address)
        {
            City = city;
        }
        public Suppliers(int pinCode) : this()
        {
            PinCode = pinCode;
        }
        public Suppliers(string firstName,string lastName,string address,string city,int pinCode,string emailId) : this()
        {
            EmailId = emailId;
        }
        public Suppliers(string firstName,string lastName,string address,string city,int pinCode,string emailId,int contactNo) : this(emailId)
        {
            ContactNo = contactNo;
        }
        public Suppliers(string firstName,string lastName,string address,string city,int pinCode,string emailId,int contactNo,string supplierOffice) : this(contactNo)
        {
            SupplierOffice = supplierOffice;
        }
        #endregion
        #region Method
        public string Save(string firstName,string lastName,string address,string city,int pinCode,string emailId,int contactNo,string supplierOffice)
        {
          FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            PinCode = pinCode;
            EmailId = emailId;
            ContactNo = contactNo;
            SupplierOffice = supplierOffice;
            return "Save the Data";
        }
        public void Detele(int supplierId)
        {
            SupplierId = supplierId;
        }
        #endregion
    }
}
