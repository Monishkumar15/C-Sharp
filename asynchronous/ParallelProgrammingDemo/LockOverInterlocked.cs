using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgrammingDemo
{
    internal class LockOverInterlocked
    {
        static object lockObject = new object();
        static void Main(string[] args)
        {
            long IncrementValue = 0;
            long SumValue = 0;
            //Parallel.For(0, 100000, number =>
            //{
            //    Interlocked.Increment(ref IncrementValue);
            //    Interlocked.Add(ref SumValue, IncrementValue);
            //});

            Parallel.For(0, 10000, number =>
            {
                //Before lock Parallel 
                lock (lockObject)
                {
                    IncrementValue++;
                    SumValue += IncrementValue;
                }
                //After lock Parallel 
            });
            Console.WriteLine($"Increment Value With Interlocked: {IncrementValue}");
            Console.WriteLine($"Sum Value With Interlocked: {SumValue}");
            Console.ReadKey();
        }
    }
}
