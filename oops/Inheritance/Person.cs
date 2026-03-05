using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public int id;
        public string name;
        public string address;
        public string phone;

        // Default Constructor
        public Person()
        {
            Console.WriteLine("Person Constructor Called");
        }

        // Parameterized Constructor
        public Person(int id, string name, string address, string phone)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            Console.WriteLine("Person Parameterized Constructor Called");
        }

        public override string ToString()
        {
            return $"Id: {this.id}, Name: {this.name}, Address: {this.address}, Phone: {this.phone}";
        }
    }

    public class Student : Person
    {
        public int cls;
        public float fees;
        public float marks;
        public char grade;

        public Student()
        {
            Console.WriteLine("Student Constructor Called");
        }

        public Student(int id, string name, string address, string phone,
                       int cls, float fees, float marks, char grade)
            : base(id, name, address, phone)
        {
            this.cls = cls;
            this.fees = fees;
            this.marks = marks;
            this.grade = grade;
            Console.WriteLine("Student Parameterized Constructor Called");
        }

        public override string ToString()
        {
            return base.ToString() +
                   $", Class: {this.cls}, Fees: {this.fees}, Marks: {this.marks}, Grade: {this.grade}";
        }
    }

    public class Staff : Person
    {
        public string designation;
        public double salary;

        public Staff()
        {
            Console.WriteLine("Staff Constructor Called");
        }

        public Staff(int id, string name, string address, string phone,
                     string designation, double salary)
            : base(id, name, address, phone)
        {
            this.designation = designation;
            this.salary = salary;
            Console.WriteLine("Staff Parameterized Constructor Called");
        }

        public override string ToString()
        {
            return base.ToString() +
                   $", Designation: {this.designation}, Salary: {this.salary}";
        }
    }

    public class Teaching : Staff
    {
        public string qualification;
        public string subject;

        public Teaching()
        {
            Console.WriteLine("Teaching Constructor Called");
        }

        public Teaching(int id, string name, string address, string phone,
                        string designation, double salary,
                        string qualification, string subject)
            : base(id, name, address, phone, designation, salary)
        {
            this.qualification = qualification;
            this.subject = subject;
            Console.WriteLine("Teaching Parameterized Constructor Called");
        }

        public override string ToString()
        {
            return base.ToString() +
                   $", Qualification: {this.qualification}, Subject: {this.subject}";
        }
    }

    public class NonTeaching : Staff
    {
        public string deptname;
        public string managerId;

        public NonTeaching()
        {
            Console.WriteLine("NonTeaching Constructor Called");
        }

        public NonTeaching(int id, string name, string address, string phone,
                           string designation, double salary,
                           string deptname, string managerId)
            : base(id, name, address, phone, designation, salary)
        {
            this.deptname = deptname;
            this.managerId = managerId;
            Console.WriteLine("NonTeaching Parameterized Constructor Called");
        }

        public override string ToString()
        {
            return base.ToString() +
                   $", Dept: {this.deptname}, ManagerId: {this.managerId}";
        }
    }
}
