using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCup
{
    static class Owner
    {
        private static List<employee> employees = new List<employee>();
        public static employee EnterEmployeeDetails(string firstName, string lastName, string address, string city, int pincode, int contactno, Gender gender, string emailid, decimal salary)
        {
            var employee = new employee(firstName, lastName, address, city, pincode, contactno, gender, emailid, salary);
            employee.Update(firstName, lastName, address, city, pincode, contactno, gender, emailid, salary);
            employees.Add(employee);
            return employee;
        }
        public static List<employee> GetAllEmployeeDetails()
        {
            return employees;
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
            customers.Add(customer);
            return customer;
        }
        public static List<Customer> GetAllCustomerDetails()
        {
        return customers;
        }
        public static Customer ExitCustomerPage()
        {
            var customer = new Customer();
            customer.logout();
            return customer;
        }
        private static List<Product> products = new List<Product>(); 
        public static Product SaveProductDetails(int productId, NameofProduct productName,NameOfBrand brandName, decimal productPrice, int quantity)
        {
            var product = new Product(productId, productName, brandName, productPrice, quantity);
            product.Save(productId, productName, brandName, productPrice, quantity);
            products.Add(product);
            return product;
        }
        public static Product DeteleProductDetails(int productId)
        {
            var product = new Product(productId);
            product.Detele(productId);
            return product;
        }
        public static List<Product> GetAllProductDetails()
        {
            return products;
        }
        public static AddNewProduct SaveNewProduct(int itemId, string itemName, decimal price, string quantity)
        {
            var addnewproduct = new AddNewProduct(itemId, itemName, price, quantity);
            addnewproduct.Save(itemId, itemName, price, quantity);
            return addnewproduct;
        }
        public static AddNewProduct DeleteAddProduct(int itemId)
        {
            var addnewproduct = new AddNewProduct(itemId);
            addnewproduct.Detele(itemId);
            return addnewproduct;
        }
        public static Suppliers SaveSuppliersInfo(int supplierId, string firstName, string lastName, string address, string city, int pinCode, string emailId, int contactNo, string supplierOffice)
        {
            var suppliers = new Suppliers(firstName, lastName, address, city, pinCode, emailId, contactNo, supplierOffice);
            suppliers.Save(firstName, lastName, address, city, pinCode, emailId, contactNo, supplierOffice);
            return suppliers;
        }
        public static Suppliers DeleteSuppliersInfo(int supplierId)
        {
            var suppliers = new Suppliers(supplierId);
            suppliers.Detele(supplierId);
            return suppliers;
        }
        public static StockDetails ClosethePage(int productId, string productName, string brandName, string avaiablequty)
        {
            var stockDetailes = new StockDetails(productId, productName, brandName, avaiablequty);
            stockDetailes.Close();
            return stockDetailes;
        }
        public static Orders Addorder(string customerName, string productName, decimal price, string quantity, decimal amount, decimal totalAmount, decimal tax, decimal grandTotal, decimal discount, decimal finalAmount)
        {
            var orders = new Orders(customerName, productName, price, quantity, amount, totalAmount, tax, grandTotal, discount, finalAmount);
            orders.AddtoOrder(productName, price);
            return orders;
        }
        public static Orders DeleteOrder(string customerName, string productName, decimal price, string quantity, decimal amount, decimal totalAmount, decimal tax, decimal grandTotal, decimal discount, decimal finalAmount)
        {
            var orders = new Orders(customerName, productName, price, quantity, amount, totalAmount, tax, grandTotal, discount, finalAmount);
            orders.DetelefromOrder(productName, price);
            return orders;
        }
    }
}
