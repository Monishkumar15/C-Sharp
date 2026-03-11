using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    internal class Demo
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(SomeMethod)
            {
                Name = "Thread One"
            };
            Thread thread2 = new Thread(SomeMethod)
            {
                Name = "Thread Two"
            };

            thread1.Start();
            thread2.Start();
            Console.ReadKey();
        }
        public static void SomeMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                i++;
                Thread.Sleep(5000);
            }
        }
    }
}
