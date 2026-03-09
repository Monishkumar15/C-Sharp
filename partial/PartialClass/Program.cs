using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Monish";
            employee.LastName = "Kumar";
            employee.Gender = "Male";
            employee.Salary = 12000;

            employee.DisplayFullName();
            employee.DisplayEmployeeDetails();

            Employee employee2 = new Employee()
            {
                FirstName = "Dinesh",
                LastName = "Karthick",
                Gender = "Male",
                Salary=20000
            };

            Console.ReadLine();


        }
    }
}
