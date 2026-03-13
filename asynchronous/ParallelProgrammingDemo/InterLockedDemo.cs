using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgrammingDemo
{
    internal class InterLockedDemo
    {
        //static void Main(string[] args)
        //{
        //    var ValueWithoutInterlocked = 0;
        //    Parallel.For(0, 100000, _ =>
        //    {
        //        //Incrementing the value
        //        ValueWithoutInterlocked++;
        //    });
        //    Console.WriteLine("Expected Result: 100000");
        //    Console.WriteLine($"Actual Result: {ValueWithoutInterlocked}");
        //    Console.ReadKey();
        //}

        //static void Main(string[] args)
        //{
        //    var ValueInterlocked = 0;
        //    Parallel.For(0, 100000, _ =>
        //    {
        //        //Incrementing the value
        //        Interlocked.Increment(ref ValueInterlocked);
        //    });
        //    Console.WriteLine("Expected Result: 100000");
        //    Console.WriteLine($"Actual Result: {ValueInterlocked}");
        //    Console.ReadKey();
        //}

        static long x;
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(SomeMethod));
            thread1.Start();
            thread1.Join();
            // Written [20]
            Console.WriteLine(Interlocked.Read(ref InterLockedDemo.x));
            Console.ReadKey();
        }
        static void SomeMethod()
        {
            // Replace x with 20.
            Interlocked.Exchange(ref InterLockedDemo.x, 20);
            // CompareExchange: if x is 20, then change to current DateTime.Now.Day or any integer variable.
            //long result = Interlocked.CompareExchange(ref Program.x, DateTime.Now.Day, 20);
            long result = Interlocked.CompareExchange(ref InterLockedDemo.x, 50, 20);
            // Returns original value from CompareExchange
            Console.WriteLine(result);
        }
    }
}
