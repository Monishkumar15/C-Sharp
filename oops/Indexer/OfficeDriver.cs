using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class OfficeDriver
    {
        static void Main()
        {
            Console.WriteLine("OfficeDriver Employees");
            Office office = new Office();
            office[0] = new Employee(101, "Prathab", "Developer", 12000, "IT", "Chenai");
            office[1] = new Employee(102, "Jayamurugan", "Tester", 12500, "QA", "Chenai");
            office[2] = new Employee(103, "Madhan", "Admin", 22000, "Administration", "Chenai");
            office[3] = new Employee(104, "Ezhil", "TL", 32000, "Lead", "Chenai");

            foreach (Employee employee in office.Employees)
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();

        }
    }
}
