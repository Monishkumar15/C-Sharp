using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticing
{
   public class ConstructorsDemo
    {
        public static int x; //It is going to be initialized by static constructor
        public int y; //It is going to be initialized by non-static constructor
        //Static Constructor
        static ConstructorsDemo()
        {
            //This constructor initialized the static variable x with default value i.e. 0
            Console.WriteLine("Static Constructor is Called");
        }
        //Non-Static Constructor
        public ConstructorsDemo(int y)
        {
            //This constructor initialized the static variable y with default value i.e. 0
            Console.WriteLine("Non-Static Constructor is Called");
        }
    }

    public class Parent
    {
        //Private Constructor
        private Parent()
        {
            Console.WriteLine("Parent Class Private Constructor is Called");
        }
        public class Child : Parent
        {
            public Child()
            {
                Console.WriteLine("Child Class Public Constructor is Called");
            }
        }
    }

}
