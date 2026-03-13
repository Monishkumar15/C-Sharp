using System;
using System.Threading.Tasks;

namespace AsynchronousApplication
{
    internal class TaskValueTaskVoidExample
    {
        static async Task Main()
        {
            await DoWorkAsync();
            Console.WriteLine("Work Finished");
        }

        static async Task DoWorkAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("Doing Work...");
        }
    }
}
