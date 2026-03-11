using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    internal class IsAliveProperty
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            Thread thread1 = new Thread(Method1);
            thread1.Start();

            if (thread1.IsAlive)
            {
                Console.WriteLine("Thread1 Method1 is still Executing");
            }
            else
            {
                Console.WriteLine("Thread1 Method1 Completed its work");
            }
            //Wait Till thread1 to complete its execution
            thread1.Join();
            if (thread1.IsAlive)
            {
                Console.WriteLine("Thread1 Method1 is still Executing");
            }
            else
            {
                Console.WriteLine("Thread1 Method1 Completed its work");
            }

            Console.WriteLine("Main Thread Ended");
            Console.Read();
        }

        static void Method1()
        {
            Console.WriteLine("Method1 - Thread1 Started");
            //Making thread to sleep for 2 seconds
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Method1 - Thread 1 Ended");
        }
    }
}
