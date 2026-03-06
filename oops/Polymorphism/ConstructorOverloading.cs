using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   
        class ConstructorOverloading
        {
            int x, y, z;
            public ConstructorOverloading(int x)
            {
                Console.WriteLine("Constructor1 Called");
                this.x = 10;
            }
            public ConstructorOverloading(int x, int y)
            {
                Console.WriteLine("Constructor2 Called");
                this.x = x;
                this.y = y;
            }
            public ConstructorOverloading(int x, int y, int z)
            {
                Console.WriteLine("Constructor3 Called");
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public void Display()
            {
                Console.WriteLine($"X={x}, Y={y}, Z={z}");
            }
        }
        class Test
        {
            static void Main(string[] args)
            {
                ConstructorOverloading obj1 = new ConstructorOverloading(10);
                obj1.Display();
                ConstructorOverloading obj2 = new ConstructorOverloading(10, 20);
                obj2.Display();
                ConstructorOverloading obj3 = new ConstructorOverloading(10, 20, 30);
                obj3.Display();
                Console.ReadKey();
            }
        }
}
