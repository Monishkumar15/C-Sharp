using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticing
{
    internal class ConstructorChainingSuper
    {
        public static void Main()
        {
            Student s1 = new Student();
            Student s2 = new Student("Monish");
        }
    }
    class Person
    {
        public Person()
        {
            Console.WriteLine("Person Constructor");
        }

        public Person(string name)
        {
            Console.WriteLine("Person Parameterized Constructor");
        }
    }

    class Student : Person
    {
        public Student() : base()
        {
            Console.WriteLine("Student Constructor");
        }

        public Student(string name) : base(name)
        {
            Console.WriteLine("Student Parameterized Constructor");
        }
    }
}
