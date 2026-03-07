using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsProject
{
    public class TestExtMethods
    {
        public static void Main()
        {
            Program p = new Program();
            p.Test1();
            p.Test2();
            p.Test3();
            p.Test4(32);

            int i = 53;
            long res = i.Factorial();
            Console.WriteLine("Factorial of {0} is {1}",i,res);

            string str = "HElLo HoW aRe yOU";
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine("ToProper() : " + str.ToProper());//add the proper case method
            Console.ReadLine();
        }
    }
}
