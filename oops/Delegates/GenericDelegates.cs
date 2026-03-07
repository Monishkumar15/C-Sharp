using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class GenericDelegates
    {
        //public delegate double AddDelegate1(int x, float y, double z);
        //public delegate void AddDelegate2(int x, float y, double z);
        //public delegate bool CheckDelegate(string str);
        public GenericDelegates() { }

        public static double AddNums1(int x, float y, double z)
        {
            return x + y + z; 
        }
        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }

        public static bool CheckLength(string str)
        {
            if(str.Length>5)
                return true;
            return false;
        }
        public static void Main(string[] args)
        {
            //Console.WriteLine("Generic Delegates");
            //AddDelegate1 obj1 = AddNums1;
            //double value = obj1(2, 13.43f, 54.3d);
            //Console.WriteLine("AddDelegate1: " + value);


            //AddDelegate2 obj2 = AddNums2;
            //obj2(5, 64.342f, 54.232d);

            //CheckDelegate obj3 = CheckLength;
            //bool res = obj3("Monish");
            //Console.WriteLine("CheckLength Greater than 5: "+res);

            Func<int, float, double, double> obj1 = AddNums1;
            double value = obj1(2, 13.43f, 54.3d);
            Console.WriteLine("AddDelegate1: " + value);


            Action<int, float, double> obj2 = AddNums2;
            obj2(5, 64.342f, 54.232d);

            Predicate<string> obj3 = CheckLength;
            bool res = obj3("Dhoni");
            Console.WriteLine("CheckLength Greater than 5: "+res);

            Console.ReadLine();



        }
    }
}
