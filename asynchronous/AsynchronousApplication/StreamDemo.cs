using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousApplication
{
    public class StreamDemo
    {
        //static void Main(string[] args)
        //{
        //    foreach (var name in GenerateNames())
        //    {
        //        Console.WriteLine(name);
        //    }
        //    Console.ReadKey();
        //}
        //private static async Task<IEnumerable<string>> GenerateNames()
        //{
        //    yield return "Anurag";
        //    yield return "Pranaya";
        //    await Task.Delay(TimeSpan.FromSeconds(3));
        //    yield return "Sambit";
        //}
        public static void Main()
        {
            foreach (var name in GenerateNames())
            {
                //You can do anything with the name
                //for example printing the name on the console
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }

        //This method is going to generate names over a period of time
        private static IEnumerable<string> GenerateNames()
        {
            yield return "Anurag";
            yield return "Pranaya";
            Thread.Sleep(3000);
            yield return "Sambit";
        }

        // static async Task Main(string[] args)
        //{
        //    await foreach(var name in GenerateNames())
        //    {
        //        Console.WriteLine(name);
        //    }
        //    Console.ReadKey();
        //}
        //private static async IAsyncEnumerable<string> GenerateNames()
        //{
        //    yield return "Anurag";
        //    yield return "Pranaya";
        //    await Task.Delay(TimeSpan.FromSeconds(3));
        //    yield return "Sambit";
        //}
    }
}
