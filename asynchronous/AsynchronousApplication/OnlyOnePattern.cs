using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousApplication
{
    internal class OnlyOnePattern
    {
        static void Main(string[] args)
        {
            SomeMethod();
            Console.ReadKey();
        }

        public static async void SomeMethod()
        {
            //Creating the collection of names
            List<string> names = new List<string>() { "Pranaya", "Anurag", "James", "Smith" };
            Console.WriteLine($"All Names");
            foreach (var item in names)
            {
                Console.Write($"{item} ");
            }

            //Creating the IEnumerable of Generic Func which points to ProcessName method
            //by passing the name and cancellation token
            var tasks = names.Select(name =>
            {
                Func<CancellationToken, Task<string>> func = (ct) => ProcessName(name, ct);
                return func;
            });

            //Calling the GenericOnlyOnePattern method by passing the collection of Func delegate
            var content = await GenericOnlyOnePattern(tasks);

            //Printing the content
            Console.WriteLine($"\n{content}");
        }

        //The Generic OnlyOne Pattern 
        //Here the parameter IEnumerable<Func<CancellationToken, Task<T>>> functions specify
        //a collection of method that takes Cancellation Token as a parameter and returns a Task<T>
        public static async Task<T> GenericOnlyOnePattern<T>(IEnumerable<Func<CancellationToken, Task<T>>> functions)
        {
            //Creating local CancellationTokenSource
            var cancellationTokenSource = new CancellationTokenSource();

            //Invoking the function by passing the Cancellation Token
            //It will invoke the functions which is pointed by the Func Generic Delegate
            var tasks = functions.Select(function => function(cancellationTokenSource.Token));

            //Calling the WhenAny method by passing the list of tasks
            //It create a task that represents the completion of one of the supplied tasks. 
            //The return task's Result is the task that completed. 
            var task = await Task.WhenAny(tasks);

            //Cancel the token
            cancellationTokenSource.Cancel();

            //Return the content
            return await task;
        }

        public static async Task<string> ProcessName(string name, CancellationToken token)
        {
            //Creating Dynamic Waiting Time
            //The following statement will generate a number between 1 and 10 dynamically
            var WaitingTime = new Random().NextDouble() * 10 + 1;
            await Task.Delay(TimeSpan.FromSeconds(WaitingTime));

            string message = $"Hello {name}";
            return message;
        }
    }
}
