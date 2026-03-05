using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    // Consuming members of a class from child class of same project (Assembly)
    // Two is a child class of Program so protected access here
    internal class Two : Program
    {
        static void Main()
        {
            Two two = new Two();
            two.Test2();//Internal Method
            two.Test3();//Protected Method
            two.Test4();//Protected Internal Method
            two.Test5();//Public Method
            two.Test6();//Private Protected Method
            //two.Hello(); 'Program.Hello()' is inaccessible due to its protection level 
            Console.ReadLine();
        }
    }
}
