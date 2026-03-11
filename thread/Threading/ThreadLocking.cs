using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    internal class ThreadLocking
    {
        public void Display()
        {
            lock (this)//SYNCHRONOIZED
            {
                Console.Write("[CSharp is an ");
                Thread.Sleep(5000);
                Console.WriteLine("Object Oriented Language]");
            }
        }
        static void Main()
        {
            ThreadLocking obj = new ThreadLocking();

            Thread T1 = new Thread(obj.Display);
            Thread T2 = new Thread(obj.Display);
            Thread T3 = new Thread(obj.Display);
            
            T1.Start(); T2.Start(); T3.Start();
            Console.ReadLine();
        }
    }
}
