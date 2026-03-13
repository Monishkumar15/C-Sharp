using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgrammingDemo
{
    internal class InterLockedLock
    {
        static readonly object lockObject = new object();
        static int IncrementValue = 0;
        const int NumberOfIteration = 10000000;

        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // Version 1: use lock.
            Parallel.For(0, NumberOfIteration, number =>
            {
                lock (lockObject)
                {
                    IncrementValue++;
                }
            });

            stopwatch.Stop();
            Console.WriteLine($"Result using Lock: {IncrementValue}");
            Console.WriteLine($"Lock took {stopwatch.ElapsedMilliseconds} Milliseconds");

            //Reset the _test value
            IncrementValue = 0;
            stopwatch.Restart();

            Parallel.For(0, NumberOfIteration, number =>
            {
                Interlocked.Increment(ref IncrementValue);
            });

            stopwatch.Stop();
            Console.WriteLine($"Result using Interlocked: {IncrementValue}");
            Console.WriteLine($"Interlocked took {stopwatch.ElapsedMilliseconds} Milliseconds");
            Console.ReadKey();
        }
    }
}
