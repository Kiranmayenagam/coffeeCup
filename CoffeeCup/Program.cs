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
            
            Console.WriteLine("Welcome to the CoffeeCup");
            while(true)
            {
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Enter Employee Details");
                Console.WriteLine("2.Update");
                Console.WriteLine("3.Delete");
                Console.WriteLine("4.Print all EmployeeDetails");
                Console.Write("Please select a choice from above");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.Write("Thank you for Visiting");
                        return;
                    case "1":
                        Console.WriteLine("FirstName");
                        var firstName = Console.ReadLine();
                        Console.WriteLine("LastName");
                        var lastName = Console.ReadLine();
                        Console.WriteLine("Address");
                        var address = Console.ReadLine();
                        Console.WriteLine("City");
                        var city = Console.ReadLine();
                        Console.WriteLine("Pincode");
                        var pincode = Convert.ToInt32 (Console.ReadLine());
                        Console.WriteLine("ContactNo");
                        var contactno = Convert.ToInt32 (Console.ReadLine());
                        Console.WriteLine("Please choice one from the Gender");
                        var Gender = Enum.GetNames(typeof(Gender));
                        for (int i = 0; i < Gender.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}.{Gender[i]}");
                        }
                        var gender = (Gender)(Convert.ToInt32(Console.ReadLine()) - 1);
                        Console.WriteLine("EmailId");
                        var emailid = Console.ReadLine();
                        Console.WriteLine("Password");
                        var password = Console.ReadLine();
                        Console.WriteLine("Salary");
                        var salary = Convert.ToDecimal (Console.ReadLine());
                        var employee = Owner.EnterEmployeeDetails(firstName, lastName, address, city, pincode, contactno, gender, emailid,password, salary);
                        Console.WriteLine($"EmployeeId:{employee.EmployeeId},FirstName:{employee.FirstName},LastName:{employee.LastName},Address:{employee.Address},City:{employee.City},Pincode:{employee.Pincode},ContactNo:{employee.ContactNo},Gender:{employee.Gender},EmailId:{employee.Emailid},Salary:{employee.Salary:C}");
                        break;
                    case "2":
                        PrintAllEmployeeDetails();
                        break;
                    case "3":
                        PrintAllEmployeeDetails();
                        break;
                    case "4":
                        PrintAllEmployeeDetails();

                       break;
                    default:
                        break;
                }
              
            }
         }
        private static void PrintAllEmployeeDetails()
        {
            var employees = Owner.GetAllEmployeeDetails();
            foreach (var ED in employees)
            {
                Console.WriteLine($"EmployeeId:{ED.EmployeeId},FirstName:{ED.FirstName},LastName:{ED.LastName},Address:{ED:Address},City:{ED.City},PinCode:{ED.Pincode},ContactNo:{ED.ContactNo},Gender:{ED.Gender},EmailId:{ED.Emailid},Salary:{ED.Salary:C}");
            }
        }
    }
}
