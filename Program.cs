using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCup
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("Kiran","Nagam","kirannagam@gamail.com","kiran","kkk@123","1234 th place","Kent","WA",9999,"USA",0123456789);
           Console.WriteLine($"Firstname:{customer.FirstName},LastName:{customer.LastName},EmailAddress:{customer.EmailAddress},UserNAme:{customer.UserName},Password:{customer.Password},Address:{customer.Address},City:{customer.City},State:{customer.State},postalcode:{customer.PostalCode},Country:{customer.Country},phonenumber:{customer.PhoneNumber}");

            var employee = new employee("John", "Smith", "0987 45thplace", "Redmond", 98021, 98487162, "Male", "johnsmith@abc.com", 4182017,3000);
            Console.WriteLine($"Employeeid:{employee.EmployeeId},FirstName:{employee.FirstName},LastName:{employee.LastName},Address:{employee.Address},City:{employee.City},Pincode:{employee.Pincode},ContactNo:{employee.ContactNo},Gender:{employee.Gender},EmailId:{employee.Emailid},DataOfJoin:{employee.DataOfJoin},Salary:{employee.Salary}");

            var addnewproduct = new AddNewProduct();
            addnewproduct.ItemId = 1234;
            addnewproduct.ItemName = "Expresso";
            addnewproduct.Price = 20;
            addnewproduct.Quantity = "10 oz";
            Console.WriteLine($"ItemId:{addnewproduct.ItemId},ItemName:{addnewproduct.ItemName},Price:{addnewproduct.Price},Quantity:{addnewproduct.Quantity}");
        }
    }
}
