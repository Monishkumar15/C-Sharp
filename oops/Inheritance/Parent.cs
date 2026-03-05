using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Parent
    {
        public Parent() {
            Console.WriteLine("Parent class constructor called");
        }
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }
    internal class Child:Parent
    {
        public Child()
        {
            Console.WriteLine("Child class constructor called");
        }

        public void Method3()
        {
            Console.WriteLine("Method 3");
        }

        static void Main()
        {
            Parent p = new Parent();
            p.Method1();
            p.Method2();

            //p.Method3(); 'Parent' does not contain a definition for 'Method3' and no accessible extension method 'Method3' accepting a first argument of type 'Parent' could be found (are you missing a using directive or an assembly reference?)

            Child child = new Child();
            child.Method1();
            child.Method2();
            child.Method3();


            Parent parent = new Child();
            parent.Method1();
            parent.Method2();
            //parent.Method3(); 'Parent' does not contain a definition for 'Method3'

            Console.WriteLine("Downcasting");

            //Downcasting
            Child parentChild = (Child)parent;
            parentChild.Method1();
            parentChild.Method2();
            parentChild.Method3();

            //2nd way
            ((Child)parent).Method3();

            Console.ReadLine();
        }
    }
}
