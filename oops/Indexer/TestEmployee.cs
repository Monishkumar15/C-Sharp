using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee(101, "Monish", "Developer", 12000d, "Technical", "Chennai");
            Console.WriteLine(Emp);
            Emp[1] = "Monishkumar";
            Console.WriteLine("Eno: "+  Emp[0]); 
            Console.WriteLine("Ename: "+  Emp[1]); 
            Console.WriteLine("Job: "+  Emp[2]); 
            Console.WriteLine("Salary: "+  Emp[3]); 
            Console.WriteLine("Department: "+  Emp[4]); 
            Console.WriteLine("Location: "+  Emp[5]);






            Employee1 Emp1 = new Employee1(102, "Karthi", "Tester", 16000, "Technical", "Bangalore");
            Console.WriteLine(Emp1);
            Emp1["ename"] = "Sathish";
            Emp1["SALARY"] = 20000;
            Console.WriteLine("Eno: " + Emp1["Eno"]);
            Console.WriteLine("Ename: " + Emp1["ename"]);
            Console.WriteLine("Job: " + Emp1["JOB"]);
            Console.WriteLine("Salary: " + Emp1["salary"]);
            Console.WriteLine("Department: " + Emp1["dname"]);
            Console.WriteLine("Location: " + Emp1["location"]);



            Console.ReadLine();

        }
    }
}
