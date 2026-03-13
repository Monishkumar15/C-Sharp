using System;
using System.Threading.Tasks;

namespace AsynchronousApplication
{
    internal class RetryPattern1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started");

            RetryMethod();

            Console.WriteLine("Main Method Completed");
            Console.ReadKey();
        }

        //public static async void RetryMethod()
        //{
        //    //It will retry 3 times, here the function is RetryOperation1
        //    try
        //    {
        //        await Retry(RetryOperation1);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("The Operation was Failed");
        //    }
        //}

        ////Generic Retry Method
        ////Func is a generate delegate which returns something, in our case it is returning a Task
        ////We are setting the default value for RetryTimes = 3 and WaitTime = 500 milliseconds
        //public static async Task Retry(Func<Task> fun, int RetryTimes = 3, int WaitTime = 500)
        //{
        //    //Reducing the for loop Exection for 1 time
        //    for (int i = 0; i < RetryTimes - 1; i++)
        //    {
        //        try
        //        {
        //            //Do the Operation
        //            //We are going to invoke whatever function the generic func delegate points to
        //            await fun();
        //            Console.WriteLine("Operation Successful");
        //            break;
        //        }
        //        catch (Exception Ex)
        //        {
        //            //If the operations throws an error
        //            //Log the Exception if you want
        //            Console.WriteLine($"Retry {i + 1}: Getting Exception : {Ex.Message}");
        //            //Wait for 500 milliseconds
        //            await Task.Delay(WaitTime);
        //        }
        //    }

        //    //Final try to execute the operation
        //    await fun();
        //}

        //public static async Task RetryOperation1()
        //{
        //    //Doing Some Processing
        //    await Task.Delay(500);

        //    //Throwing Exception so that retry will work
        //    throw new Exception("Exception Occurred in RetryOperation1");
        //}
        public static async void RetryMethod()
        {
            try
            {
                var result = await Retry(RetryOperationValueReturning);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The Operation was Failed");
            }
        }

        public static async Task<T> Retry<T>(Func<Task<T>> fun, int RetryTimes = 3, int WaitTime = 500)
        {
            for (int i = 0; i < RetryTimes - 1; i++)
            {
                try
                {
                    return await fun();
                }
                catch (Exception Ex)
                {
                    Console.WriteLine($"Retry {i + 1}: Getting Exception : {Ex.Message}");
                    await Task.Delay(WaitTime);
                }
            }
            return await fun();
        }

        public static async Task<string> RetryOperationValueReturning()
        {
            await Task.Delay(500);
            return "Operation Successful";
        }
    }
}
