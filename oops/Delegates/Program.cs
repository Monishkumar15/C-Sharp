using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
      public delegate int AddDelegate(int a, int b);
      public delegate string SayDelegate(string name);
    public class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public string SayHello(string s)
        {
            return "Hello " + s;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            string res = p.SayHello("Monish");
            Console.WriteLine(res);
            Console.WriteLine(Program.Add(10, 30));

            Console.WriteLine();
            Console.WriteLine("Delegate Approach\n-----------------------\n");
            AddDelegate obj = new AddDelegate(Add);
            int result = obj(10, 20);
            Console.WriteLine(result);
            Console.WriteLine("Invoke way: "+obj.Invoke(10,20));

            SayDelegate say = new SayDelegate(p.SayHello);
            Console.WriteLine(say("Monishkumar"));
            Console.WriteLine("Invoke way: "+say.Invoke("Rohit"));

            Console.ReadLine();
        }
    }
}
