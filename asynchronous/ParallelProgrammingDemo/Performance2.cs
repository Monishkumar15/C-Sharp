using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProgrammingDemo
{
    public class Performance2
    {
        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Standard Foreach Loop Started");
            stopwatch.Start();
            List<int> integerList = Enumerable.Range(1, 10).ToList();
            foreach (int i in integerList)
            {
                DoSomeIndependentTask(i);
            }
            ;

            stopwatch.Stop();
            Console.WriteLine("Standard Foreach Loop Ended");
            Console.WriteLine($"Time Taken by Standard Foreach Loop in Miliseconds {stopwatch.ElapsedMilliseconds}");


            Console.WriteLine("\nParallel Foreach Loop Started");
            stopwatch.Restart();

            Parallel.ForEach(integerList, i =>
            {
                DoSomeIndependentTask(i);
            });

            stopwatch.Stop();
            Console.WriteLine("Parallel Foreach Loop Ended");

            Console.WriteLine($"Time Taken by Parallel Foreach Loop in Miliseconds {stopwatch.ElapsedMilliseconds}");

            Console.ReadLine();
        }

        static void DoSomeIndependentTask(int i)
        {
            Console.WriteLine($"Number: {i}");
        }
    }
}
