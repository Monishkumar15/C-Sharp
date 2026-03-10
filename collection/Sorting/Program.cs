using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class Program
    {
        public static int compareDepartment(Employee e1, Employee e2) {
            return e1.EDepartment.CompareTo(e2.EDepartment);
        }
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
            employees.Reverse();
            Console.WriteLine("\nEmployee sorting based on EName using and specific range IComparer<Employee>\n");
            employees.Sort(2, 3, sortName);
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("\nEmployee sorting based on EName using delegates\n");
            Console.WriteLine("1st way");
            Comparison<Employee> obj1 = new Comparison<Employee>(compareDepartment);
            employees.Sort(obj1);
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("2nd way using delegates sort by address");
            employees.Sort(delegate (Employee e1, Employee e2) {
                return e1.EAddress.CompareTo(e2.EAddress);
            });
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("3rd way using delegates sort by department in descending order");
            employees.Sort((Employee e1, Employee e2) => e2.EDepartment.CompareTo(e1.EDepartment));
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            //employees.Sort(1,4,obj1);

            Console.ReadLine();
        }
    }
}
