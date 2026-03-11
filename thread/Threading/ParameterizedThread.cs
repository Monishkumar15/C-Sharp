using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    internal class ParameterizedThread
    {
        static void Test(object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("Test1: " + i);
            }

        }
        static void Main()

        {
            Console.WriteLine("Main Thread start");
            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test);
            Thread t = new Thread(obj);
            t.Start(40);
            Console.WriteLine("Main Thread End");
        }
    }
}
