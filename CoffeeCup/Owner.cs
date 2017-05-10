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
        private static List<AddNewProduct> addnewproducts = new List<AddNewProduct>();
        public static AddNewProduct SaveNewProduct(int itemId, string itemName, decimal price, string quantity)
        {
            var addnewproduct = new AddNewProduct(itemId, itemName, price, quantity);
            addnewproduct.Save(itemId, itemName, price, quantity);
            addnewproducts.Add(addnewproduct);
            return addnewproduct;
        }
        public static List<AddNewProduct> GetAllNewProductsDetails()
        {
            return addnewproducts;
        }
        public static AddNewProduct DeleteAddProduct(int itemId)
        {
            var addnewproduct = new AddNewProduct(itemId);
            addnewproduct.Detele(itemId);
            return addnewproduct;
        }
        private static List<Suppliers> supplier = new List<Suppliers>();
        public static Suppliers SaveSuppliersInfo(int supplierId, string firstName, string lastName, string address, string city, int pinCode, string emailId, int contactNo, string supplierOffice)
        {
            var suppliers = new Suppliers(firstName, lastName, address, city, pinCode, emailId, contactNo, supplierOffice);
            suppliers.Save(firstName, lastName, address, city, pinCode, emailId, contactNo, supplierOffice);
            supplier.Add(suppliers);
            return suppliers;
        }
        public static List<Suppliers> GetAllSupplierDetails()
        {
            return supplier;
        }
        public static Suppliers DeleteSuppliersInfo(int supplierId)
        {
            var suppliers = new Suppliers(supplierId);
            suppliers.Detele(supplierId);
            return suppliers;
        }
        private static List<StockDetails> stockdetail = new List<StockDetails>(); 
        public static StockDetails ClosethePage(int productId, NameofProduct productName,NameOfBrand  brandName, string avaiablequty)
        {
            var stockDetailes = new StockDetails(productId, productName, brandName, avaiablequty);
            stockDetailes.Close();
            stockdetail.Add(stockDetailes);
            return stockDetailes;
        }
        public static List<StockDetails> GetAllStockDetails()
        {
            return stockdetail;
        }
        private static List<Orders> order = new List<Orders>();
       public static Orders Addorder(string customerName, NameofProduct productName, decimal price, string quantity, decimal amount, decimal totalAmount, decimal tax, decimal grandTotal, decimal discount, decimal finalAmount)
        {
            var orders = new Orders(customerName, productName, price, quantity, amount, totalAmount, tax, grandTotal, discount, finalAmount);
            orders.AddtoOrder(productName, price);
            order.Add(orders);
            return orders;
        }
        public static List<Orders> GetAllOrderDetails()
        {
            return order;
        }
        public static Orders DeleteOrder(string customerName, NameofProduct productName, decimal price, string quantity, decimal amount, decimal totalAmount, decimal tax, decimal grandTotal, decimal discount, decimal finalAmount)
        {
            var orders = new Orders(customerName, productName, price, quantity, amount, totalAmount, tax, grandTotal, discount, finalAmount);
            orders.DetelefromOrder(productName, price);
            return orders;
        }
    }
}
