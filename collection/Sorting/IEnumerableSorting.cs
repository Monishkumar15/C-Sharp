using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class IEnumerableSorting
    {
        public static void Main()
        {
            Organization Students = new Organization();
            Students.Add(new Student { Id= 101, Name="Monish", Subject="Maths", Marks=12 });
            Students.Add(new Student { Id= 103, Name="Kamesh", Subject="English", Marks=54 });
            Students.Add(new Student { Id= 104, Name="DInesh", Subject="Science", Marks=78 });
            Students.Add(new Student { Id= 102, Name="Ramesh", Subject="Maths", Marks=8 });

            foreach (Student student in Students)
            {
                Console.WriteLine(student);   
            }
            Console.ReadLine();
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public double Marks { get; set; }

        public override string ToString()
        {
            return $"Student: [Id: {this.Id}, Name:{this.Name}, Subject:{this.Subject}, Marks:{this.Marks}]";
        }
    }
    public class Organization : IEnumerable
    {
    
        List<Student> Students = new List<Student>();

        public void Add(Student std)
        {
            Students.Add(std);
        }

        public int Count
        {
            get {  return Students.Count; } 
        }
         
        public Student this[int index]
        {
            get
            {
                return Students[index];  
            }
        }
        public IEnumerator GetEnumerator()
        {
            return new OrganizationEnumerator(this);
        }
    }

    public class OrganizationEnumerator : IEnumerator
    {
        Organization OrgColl;
        int CurrentIndex;
        Student CurrentStudent;

        public OrganizationEnumerator( Organization OrgColl)
        {
            this.OrgColl = OrgColl;
            CurrentIndex = -1;
        } 
        public object Current
        {
            get
            {
                return CurrentStudent;
            }
        }

        public bool MoveNext()
        {
            if(++CurrentIndex>= OrgColl.Count)
            {
                return false;
            }
            else
            {
                CurrentStudent = OrgColl[CurrentIndex];
            }
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

}