using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticing
{
    class ConstructorChainingThis
    {
        public int id;
        public string name;

        public ConstructorChainingThis()
        {
            Console.WriteLine("Default Constructor");
        }

        public ConstructorChainingThis(int id) : this()
        {
            this.id = id;
            Console.WriteLine("One Parameter Constructor");
        }

        public ConstructorChainingThis(int id, string name) : this(id)
        {
            this.name = name;
            Console.WriteLine("Two Parameter Constructor");
        }


        public static void Main()
        {
            ConstructorChainingThis c1 = new ConstructorChainingThis();
            Console.WriteLine("***************************************");
            ConstructorChainingThis c2 = new ConstructorChainingThis(1);
            Console.WriteLine("***************************************");
            ConstructorChainingThis c3 = new ConstructorChainingThis(3, "hi");
        }
    }
}
