using System;

namespace Polymorphism
{
    //Method Overloading in parent and child class
    public class ClassDriverBase
    {
        public static void Main(string[] args)
        {
            Class2 obj = new Class2();
            obj.Add(10, 20);
            obj.Add(10.5f, 20.7f);
            obj.Add("Pranaya", "Rout");
            Console.ReadKey();
        }
       
    }
}