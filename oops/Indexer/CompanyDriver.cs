using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class CompanyDriver
    {
        static void Main()
        {
            Console.WriteLine("Company Employees");
            Company c = new Company();
            c[0] = new Employee(101, "Monish", "Developer", 12000, "IT", "Chenai");
            c[1] = new Employee(102, "Dinesh", "Tester", 12500, "QA", "Chenai");
            c[2] = new Employee(103, "Vignesh", "Admin", 22000, "Administration", "Chenai");
            c[3] = new Employee(104, "Ramesh", "TL", 32000, "Lead", "Chenai");
            
            foreach(Employee employee in c.Employees)
            {
                if (employee != null)
                    Console.WriteLine(employee);
                else
                    break;
            }   
            Console.ReadLine();

        }
    }
}
