using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgrammingDemo
{
    internal class ParallelInvoke
    {
        //static void Main()
        //{
        //    Stopwatch stopWatch = new Stopwatch();

        //    stopWatch.Start();
        //    ////Calling Three methods sequentially
        //    //Method1();
        //    //Method2();
        //    //Method3();
        //    //Calling Three methods Parallely

        //    Parallel.Invoke(
        //         Method1, Method2, Method3
        //    );
        //    stopWatch.Stop();

        //    Console.WriteLine($"Sequential Execution Took {stopWatch.ElapsedMilliseconds} Milliseconds");
        //    Console.ReadKey();
        //}

        static void Main()
        {
            Parallel.Invoke(
                 NormalAction, // Invoking Normal Method
                 delegate ()   // Invoking an inline delegate 
                 {
                     Console.WriteLine($"Method 2, Thread={Thread.CurrentThread.ManagedThreadId}");
                 },
                () =>   // Invoking a lambda expression
                {
                    Console.WriteLine($"Method 3, Thread={Thread.CurrentThread.ManagedThreadId}");
                }
            );
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
        static void NormalAction()
        {
            Console.WriteLine($"Method 1, Thread={Thread.CurrentThread.ManagedThreadId}");
        }
        static void Method1()
        {
            Thread.Sleep(200);
            Console.WriteLine($"Method 1 Completed by Thread={Thread.CurrentThread.ManagedThreadId}");
        }
        static void Method2()
        {
            Thread.Sleep(200);
            Console.WriteLine($"Method 2 Completed by Thread={Thread.CurrentThread.ManagedThreadId}");
        }
        static void Method3()
        {
            Thread.Sleep(200);
            Console.WriteLine($"Method 3 Completed by Thread={Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
