using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers2
{
    //Consuming members of a class from child class of different project (Assembly)
    internal class Four : AccessSpecifiers.Program
    {
        static void Main(string[] args)
        {
            Four four = new Four();
            four.Test3();// Protected Method
            four.Test4();// Protected Internal Method
            four.Test5();// Public Method
            Console.ReadLine();
        }
    }
}
