using System;
using System.Threading.Tasks;

namespace AsynchronousApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started......");

            SomeMethod();

            Console.WriteLine("Main Method End");
            Console.ReadKey();
        }

        //public static void SomeMethod()
        //{
        //    Console.WriteLine("Some Method Started......");

        //    Thread.Sleep(TimeSpan.FromSeconds(10));
        //    Console.WriteLine("\n");
        //    Console.WriteLine("Some Method End");
        //}
        //public async static void SomeMethod()
        //{
        //    Console.WriteLine("Some Method Started......");
        //    //Thread.Sleep(TimeSpan.FromSeconds(10));
        //    await Task.Delay(TimeSpan.FromSeconds(10));
        //    Console.WriteLine("\n");
        //    Console.WriteLine("Some Method End");
        //}
        public async static void SomeMethod()
        {
            Console.WriteLine("Some Method Started......");

            await Wait();

            Console.WriteLine("Some Method End");
        }

        private static async Task Wait()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("\n10 Seconds wait Completed\n");
        }
    }
}
