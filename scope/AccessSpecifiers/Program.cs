using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    // Consuming members of a class from same class
    public class Program
    {
        private void Test1()
        {
            Console.WriteLine("Private Method");
        }
        internal void Test2()
        {
            Console.WriteLine("Internal Method");
        }
        protected void Test3()
        {
            Console.WriteLine("Protected Method");
        }
        protected internal void Test4()
        {
            Console.WriteLine("Protected Internal Method");
        }
        public void Test5()
        {
            Console.WriteLine("Public Method");
        }

        void Hello()
        {
            Console.WriteLine("Hello Default Method");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Test1();
            program.Test2();    
            program.Test3();
            program.Test4();
            program.Test5();
            program.Hello();
            Console.ReadLine();
        }
    }
}
