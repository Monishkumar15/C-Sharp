using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class CompaniesDriver
    {
        static void Main()
        {
            Console.WriteLine("CompaniesDriver Employees");
            Companies cmp = new Companies();
            cmp[0] = new Employee(101, "Rupesh", "Developer", 12000, "IT", "Chenai");
            cmp[1] = new Employee(102, "Rohan", "Tester", 12500, "QA", "Chenai");
            cmp[2] = new Employee(103, "Sudharson", "Admin", 22000, "Administration", "Chenai");
            cmp[3] = new Employee(104, "Dhurshanth", "TL", 32000, "Lead", "Chenai");
            //1stway
            foreach (Employee employee in cmp)
            {
                Console.WriteLine(employee);
            }

            //2nd way complier converts foreach to this IEnumerator Iterator
            IEnumerator<Employee> enumerator = cmp.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Employee emp = enumerator.Current;
                Console.WriteLine(emp);
            }
            Console.ReadLine();
                   /*   ↓
            Company.GetEnumerator()
                      ↓
            List<Employee>.GetEnumerator()
                      ↓
            MoveNext()
                      ↓
            Current*/

        }
    }
}
