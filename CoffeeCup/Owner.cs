using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCup
{
    public static class Owner
    {
        private static List<employee> employees = new List<employee>();
        private static CoffeeModel db = new CoffeeModel();
        public static employee EnterEmployeeDetails(string firstName, string lastName, string address, string city, int pincode, int contactno, Gender gender, string emailid,string password, decimal salary)
        {
            var employee = new employee(firstName, lastName, address, city, pincode, contactno, gender, emailid,password, salary);
            employee.Update(firstName, lastName, address, city, pincode, contactno, gender, emailid,password, salary);
            employee.login(emailid, password);
            db.employees.Add(employee);
            db.SaveChanges();
            return employee;
        }
        public static List<employee> GetAllEmployeeDetails()
        {
            return db.employees.ToList();
        }
        public static employee DeteleEmployeeDetails(int employeeid)
        {
            var employee = new employee(employeeid);
            employee.Delete(employeeid);
            return employee;
        }
        private static List<Customer> customers = new List<Customer>();
        
        public static Customer EnterCustomerDetails(string firstName, string lastName, string emailAddress, string userName, string password, string address, string city, string state, int pinCode, string country, int phoneNumber)
        {
            var customer = new Customer(firstName, lastName, emailAddress, userName, password, address, city, state, pinCode, country, phoneNumber);
            customer.Update(firstName, lastName, emailAddress, userName, password, address, city, state, pinCode, country, phoneNumber);
            customer.Delete(userName);
            customer.Login(userName, password);
            db.customers.Add(customer);
            db.SaveChanges();

            return customer;
        }
        public static List<Customer> GetAllCustomerDetails()
        {
            return db.customers.ToList();
        }
        public static Customer ExitCustomerPage()
        {
            var customer = new Customer();
            customer.logout();
            return customer;
        }
        
        private static List<Orders> order = new List<Orders>();
        
        public static Orders AddOrder(string customerName, NameofProduct productName, decimal price, string quantity, decimal amount, decimal totalAmount, decimal tax, decimal grandTotal, decimal discount, decimal finalAmount)
        {
            var orders = new Orders(customerName, productName, price, quantity, amount, totalAmount, tax, grandTotal, discount, finalAmount);
            orders.AddtoOrder(productName, price);
            db.order.Add(orders);
            db.SaveChanges();
            return orders;
        }
        public static List<Orders> GetAllOrderDetails()
        {
            return db.order.ToList();
        }
        
        
    }
}
