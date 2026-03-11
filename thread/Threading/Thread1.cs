using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    internal class Thread1
    {
        public Thread1() { }
         static void Test1()
        {
            Console.WriteLine("Thread1 is Starting:");
            for(int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test1: " + i);
            }
            Console.WriteLine("Thread1 is Existing.");
        }
         static void Test2()
        {
            Console.WriteLine("Thread2 is Starting:");
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test2: " + i);
                if (i == 50)
                {
                    Console.WriteLine("Thread2 going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread2 woke up");
                }
            }
            Console.WriteLine("Thread2 is Existing.");
        }
         static void Test3()
        {
            Console.WriteLine("Thread3 is Starting:");
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test3: " + i);
            }
            Console.WriteLine("Thread3 is Existing.");
        }
         static void Test4()
        {
            Console.WriteLine("Thread4 is Starting:");
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test4: " + i);
            }
            Console.WriteLine("Thread4 is Existing.");
        }
         static void Test5()
        {
            Console.WriteLine("Thread5 is Starting:");
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test5: " + i);
            }
            Console.WriteLine("Thread5 is Existing.");
        }

        public static void Main()
        {
            Console.WriteLine("Main Thread Start");
            //Test1();
            //Test2();
            //Test3();
            ThreadStart threadStart = new ThreadStart(Test1); 
            Thread T1 = new Thread(threadStart);
            T1.Start();
            
            Thread T2 = new Thread(Test2);
            T2.Start();

            ThreadStart threadStart2 = Test3;
            Thread T3 = new Thread(threadStart2);
            T3.Start();

            ThreadStart threadStart3 = delegate { Test4(); };
            Thread T4 = new Thread(threadStart3);
            T4.Start();

            ThreadStart threadStart4 = () => Test5();
            Thread T5 = new Thread(threadStart4);
            T5.Start();

            T1.Join();
            T2.Join();
            T3.Join();T4.Join();T5.Join();
            Console.WriteLine("Main Thread End");
            Console.ReadLine();
        }
    }
}
