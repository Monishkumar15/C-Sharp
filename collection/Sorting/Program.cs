using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(101,"Ramesh","Developer",8976548765l,"Chennai"));
            employees.Add(new Employee(106,"Dinesh","TeamLead",6355489754l,"Vellore"));
            employees.Add(new Employee(109,"Gautham","HR",7864213584l,"Arani"));
            employees.Add(new Employee(103,"Anisha","Testing",9564873254l,"Coimbatore"));
            employees.Add(new Employee(102,"Charulatha","Admin",6487593649l,"Madurai"));

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("\nEmployee sorting based on EId using IComparable<Employee>\n");
            employees.Sort();
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            EmployeePhone employeePhone = new EmployeePhone();
            employees.Sort(employeePhone);

            Console.WriteLine("\nEmployee sorting based on EPhone using IComparer<Employee>\n");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            EmployeeSortBasedOnName sortName = new EmployeeSortBasedOnName();
            employees.Sort(sortName);
            Console.WriteLine("\nEmployee sorting based on EName using IComparer<Employee>\n");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.ReadLine();
        }
    }
}
