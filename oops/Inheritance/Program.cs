using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "Monish", "Chennai", "9876543210",
                                10, 20000, 85, 'A');

            Console.WriteLine(s);
            Console.WriteLine("************************************************************");

            Teaching t = new Teaching(2, "Ravi", "Chennai", "9999999999",
                                      "Professor", 75000,
                                      "PhD", "Computer Science");
            Console.WriteLine(t);
            Console.WriteLine("************************************************************");

            NonTeaching nt = new NonTeaching(3, "Suresh", "Chennai", "8888888888",
                                             "Clerk", 30000,
                                             "Admin", "M101");
            Console.WriteLine(nt);
            Console.WriteLine("************************************************************");
        }
    }
}
