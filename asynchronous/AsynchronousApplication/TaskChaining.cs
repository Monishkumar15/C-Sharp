using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousApplication
{
    internal class TaskChaining
    {
        //static void Main(string[] args)
        //{
        //    Task<int> task = Task.Run(() =>
        //    {
        //        return 10;
        //    });
        //    task.ContinueWith((i) =>
        //    {
        //        Console.WriteLine("TasK Canceled");
        //    }, TaskContinuationOptions.OnlyOnCanceled);
        //    task.ContinueWith((i) =>
        //    {
        //        Console.WriteLine("Task Faulted");
        //    }, TaskContinuationOptions.OnlyOnFaulted);
        //    var completedTask = task.ContinueWith((i) =>
        //    {
        //        Console.WriteLine("Task Completed");
        //    }, TaskContinuationOptions.OnlyOnRanToCompletion);
        //    completedTask.Wait();
        //    Console.ReadKey();
        //}
        //public static void Main()
        //{
        //    Console.WriteLine("Main Method Started");

        //    //Creating the Parent Task
        //    var parentTask = Task.Factory.StartNew(() => {
        //        Console.WriteLine("Outer Task Started");

        //        //Creating the Child Task
        //        var childTask = Task.Factory.StartNew(() => {
        //            Console.WriteLine("Child Task Started.");
        //            Thread.Sleep(5000);
        //            Console.WriteLine("Child Task Completed");
        //        });

        //        Console.WriteLine("Outer Task Completed");
        //    });

        //    //Waiting for the Parent Task to completed. Not the Child Task
        //    parentTask.Wait();
        //    Console.WriteLine("Main Method Completed");
        //    Console.ReadKey();
        //}
        //public static void Main()
        //{
        //    Console.WriteLine("Main Method Started");

        //    //Creating the Parent Task
        //    var parentTask = Task<string>.Factory.StartNew(() => {
        //        Console.WriteLine("Outer Task Started");

        //        //Creating the Child Task
        //        var childTask = Task<string>.Factory.StartNew(() => {
        //            Console.WriteLine("Child Task Started");
        //            Thread.Sleep(5000);
        //            Console.WriteLine("Child Task Completed");
        //            return "Task Completed";
        //        });

        //        // Parent Task will wait for detached Child Task to complete its execution
        //        return childTask.Result;
        //    });

        //    //Here, parentTask.Result will block the Main thread, till the Parent task complete its execution
        //    Console.WriteLine($"Parent Task Returned: {parentTask.Result}");
        //    Console.WriteLine("Main Method Completed");
        //    Console.ReadKey();
        //}
        //public static void Main()
        //{
        //    Console.WriteLine("Main Method Started");
        //    //Creating the Parent Task
        //    var parentTask = Task.Factory.StartNew(() => {
        //        Console.WriteLine("Outer Task Started");
        //        //Creating the Child Task
        //        var childTask = Task.Factory.StartNew(() => {
        //            Console.WriteLine("Child Task Started");
        //            Thread.Sleep(5000);
        //            Console.WriteLine("Child Task Completed");
        //        }, TaskCreationOptions.AttachedToParent);
        //        Console.WriteLine("Outer Task Completed");
        //    });
        //    //Waiting for the Parent Task to completed.
        //    parentTask.Wait();
        //    Console.WriteLine("Main Method Completed");
        //    Console.ReadKey();
        //}
        /*Main Method Started
        Outer Task Started
        Outer Task Completed
        Child Task Started
        Child Task Completed
        Main Method Completed*/

        //How to Prevent Parent tasks from attached Child Tasks in C#?

        public static void Main()
        {
            Console.WriteLine("Main Method Started");
            //Creating the Parent Task with DenyChildAttach Option
            var parentTask = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Outer Task Started");
                //Creating the Child Task with AttachedToParent
                var childTask = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Child Task Started");
                    Thread.Sleep(5000);
                    Console.WriteLine("Child Task Completed");
                }, TaskCreationOptions.AttachedToParent);
                Console.WriteLine("Outer Task Completed");
            }, TaskCreationOptions.DenyChildAttach);
            //Waiting for the Parent Task to completed.
            parentTask.Wait();
            Console.WriteLine("Main Method Completed");
            Console.ReadKey();
        }
    }
}
