using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Teacher
    {
        public Teacher() {
            Console.WriteLine("Teacher constructor called");
        }

        public virtual void Test1()
        {
            Console.WriteLine("Teacher Test1 method called");
        }
        public void Test2()
        {
            Console.WriteLine("Teacher Test2 method called");
        }
    }
    class Student : Teacher
    {
        public Student()
        {
            Console.WriteLine("Student constructor called");
        }

        //Method overriding
        public override void Test1()
        {
            Console.WriteLine("Student Test1 method called");
        }


        //Method Hiding
        public new void Test2()
        {
            Console.WriteLine("Student Test2 Method called");
        }
    }

    class School
    {
        public School() { }
        private static void Main()
        {
            Teacher teacher = new Teacher();
            teacher.Test1();
            teacher.Test2();

            Student student = new Student();
            student.Test1();
            student.Test2();

            Teacher teacher1 = new Student();
            teacher1.Test1();
            teacher1.Test2();
        }
    }
}
