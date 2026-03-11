using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    internal class SemaphoreDemo
    {
        static Semaphore semaphore = new Semaphore(2, 2);

        static void Task()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " waiting");

            semaphore.WaitOne();

            Console.WriteLine(Thread.CurrentThread.Name + " entered >>>>");

            Thread.Sleep(2000);

            Console.WriteLine(Thread.CurrentThread.Name + " leaving ----");

            semaphore.Release();
        }

        static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread t = new Thread(Task);
                t.Name = "Thread " + i;
                t.Start();
            }
        }
        //public static Semaphore semaphore = null;
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        //Try to Open the Semaphore if Exists, if not throw an exception
        //        semaphore = Semaphore.OpenExisting("SemaphoreDemo");
        //    }
        //    catch (Exception Ex)
        //    {
        //        //If Semaphore not Exists, create a semaphore instance
        //        //Here Maximum 2 external threads can access the code at the same time
        //        semaphore = new Semaphore(2, 2, "SemaphoreDemo");
        //    }
        //    Console.WriteLine("External Thread Trying to Acquiring");
        //    semaphore.WaitOne();
        //    //This section can be access by maximum two external threads: Start
        //    Console.WriteLine("External Thread Acquired");
        //    Console.ReadKey();
        //    //This section can be access by maximum two external threads: End
        //    semaphore.Release();
        //}
    }
}
