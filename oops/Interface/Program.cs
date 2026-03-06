using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
        class Program
        {
            static void Main()
            {
                ImplementationClass obj1 = new ImplementationClass();
                //Using obj1 we can call the Add method directly because
                //It is implemented using public access specifier
                obj1.Add(10, 20);

                //We need to typecast obj1 to ITestInterface1 to call the Sub
                //method because Sub method is implemented using Interface name
                ((ITestInterface1)obj1).Sub(100, 20);

                //We can call the method directly using the interface reference
                //Typecasting is not required in this case
                ITestInterface1 obj2 = new ImplementationClass();
                obj2.Add(200, 50);
                obj2.Sub(200, 50);

                Console.ReadKey();
            }
        }

        interface ITestInterface1
        {
            void Add(int num1, int num2);
            void Sub(int num1, int num2);
        }

        public class ImplementationClass : ITestInterface1
        {
            //Interface Method Implementation
            public void Add(int num1, int num2)
            {
                Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
            }

            //This method purely belongs to ImplementationClass
            void ITestInterface1.Sub(int num1, int num2)
            {
                Console.WriteLine($"Divison of {num1} and {num2} is {num1 - num2}");
            }
        }
   
}
