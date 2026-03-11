using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    internal class MutexDemo
    {
        //static Mutex _mutex;

        //static void Main()
        //{
        //    //If IsSingleInstance returns true continue with the Program else Exit the Program
        //    if (!IsSingleInstance())
        //    {
        //        Console.WriteLine("More than one instance"); // Exit program.
        //    }
        //    else
        //    {
        //        Console.WriteLine("One instance"); // Continue with program.
        //    }
        //    // Stay Open.
        //    Console.ReadLine();
        //}

        //static bool IsSingleInstance()
        //{
        //    try
        //    {
        //        // Try to open Existing Mutex.
        //        //If MyMutex is not opened, then it will throw an exception
        //        Mutex.OpenExisting("MyMutex");
        //    }
        //    catch
        //    {
        //        // If exception occurred, there is no such mutex.
        //        _mutex = new Mutex(true, "MyMutex");

        //        // Only one instance.
        //        return true;
        //    }

        //    // More than one instance.
        //    return false;
        //}
        static Mutex mutex = new Mutex();

        static void Task()
        {
            mutex.WaitOne();

            Console.WriteLine("Thread entered critical section");
            Thread.Sleep(2000);

            mutex.ReleaseMutex();
        }

        static void Main()
        {
            Thread t1 = new Thread(Task);
            Thread t2 = new Thread(Task);

            t1.Start();
            t2.Start();
        }
    }
}
