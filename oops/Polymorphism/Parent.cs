using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Parent
    {
        public Parent() {
            Console.WriteLine("Parent constructor called");
        }
        public virtual void Welcome()
        {
            Console.WriteLine("Welocme to Parent");
        }
    }
    class Child : Parent
    {
        public Child() {
            Console.WriteLine("Child constructor called");
        }

        public override void Welcome()
        {
            Console.WriteLine("Welcome to Child");
        }

        public static void Main()
        {
            Child c1 = new Child();
            c1.Welcome();
        }
    }
}
