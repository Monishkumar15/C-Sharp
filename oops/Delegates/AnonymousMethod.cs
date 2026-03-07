using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate string GreetingDelegate(string name);
    public class AnonymousMethod
    {
        public static String Greeting(string name)
        {
            return $"Hello {name} a very good morning";
        }
        static void Main()
        {

            GreetingDelegate obj = Greeting;
            string str = obj("Monish");
            Console.WriteLine(str);

            //anonymous method
            GreetingDelegate obj2 = delegate (string name)
            {
                return $"Hello {name} a very good afternoon";
            };
            Console.WriteLine(obj2("Virat"));
            Console.ReadLine();

        }
    }
}
