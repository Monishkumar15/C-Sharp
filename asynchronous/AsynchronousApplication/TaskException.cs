using System;
using System.Threading.Tasks;

namespace AsynchronousApplication
{
    internal class TaskException
    {
        static async Task Main()
        {
            try
            {
                await TestMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught Exception: " + ex.Message);
            }
        }

        static async Task TestMethod()
        {
            Console.WriteLine("Method Started");

            // Exception BEFORE await
            throw new Exception("Synchronous Exception");

            await Task.Delay(1000);
        }

        //static async Task TestMethod()
        //{
        //    Console.WriteLine("Method Started");

        //    await Task.Delay(1000);

        //    // Exception AFTER await
        //    throw new Exception("Asynchronous Exception");
        //}
    }
}
