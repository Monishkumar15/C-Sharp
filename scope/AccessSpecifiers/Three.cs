using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{

    //consuming members of a class from non-child class of same project
    internal class Three
    {
        static void Main()
        {
            Program program = new Program();
            program.Test2();// Internal Method
            program.Test4();// Protected Internal Method
            program.Test5();// Public Method
        }
    }
}
