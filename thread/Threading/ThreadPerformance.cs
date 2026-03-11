using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    internal class ThreadPerformance
    {
        public static void IncrementCounter1()
        {
            long count = 0;
            for(int i = 0; i <1000000001; i++)
            {
                count++;
            }
            Console.WriteLine("IncrementCount1: " + count);
        }
        public static void IncrementCounter2()
        {
            long count = 0;
            for(int i = 0; i <1000000001; i++)
            {
                count++;
            }
            Console.WriteLine("IncrementCount2: " + count);
        }

        public static void Main()
        {
            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();
            Thread t1 = new Thread(IncrementCounter1);
            Thread t2 = new Thread(IncrementCounter2);


            s1.Start();
            IncrementCounter1();
            IncrementCounter2 ();
            s1.Stop();

            s2.Start();
            t1.Start();
            t2.Start();
            s2.Stop();

            t1.Join();
            t2.Join();

            Console.WriteLine("Time taken to complete the work in single threaded model: " +s1.ElapsedMilliseconds);
            Console.WriteLine("Time taken to complete the work in multi threaded model: " +s2.ElapsedMilliseconds);
            Console.ReadLine();
         }
    }
}
