using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Employee
    {
        public Employee() { }
        int employeeID;
        double employeeSalary;

        public  void findEmployee()
        {
            try{Console.WriteLine("Enter Employee Details");

            Console.WriteLine("Enter Employee Id");
            while (!int.TryParse(Console.ReadLine(), out employeeID))
            {
                Console.WriteLine("Invalid Id. Please enter numbers only:");
            }
            Console.WriteLine("Enter Employee Name");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            while(!double.TryParse(Console.ReadLine(),out employeeSalary))
            {
                Console.WriteLine("Invalid salary. Please enter decimal only");
            }
            Console.WriteLine("Enter Employee Address");
            string employeeAddress = Console.ReadLine();
            Console.WriteLine("Enter Employee Department");
                string employeeDepartment = Console.ReadLine();

            Console.WriteLine("\nEntered Employee Details are as follows");
            Console.WriteLine($"Employee Id is: {employeeID}");
            Console.WriteLine($"Employee Name is: {employeeName}");
            Console.WriteLine($"Employee Salary is: {employeeSalary}");
            Console.WriteLine($"Employee Address is: {employeeAddress}");
            Console.WriteLine($"Employee Department is: {employeeDepartment}");
            }catch(Exception e)
            {
                Console.WriteLine(e+ "Invalid argument");
            }
        }
    }
}
