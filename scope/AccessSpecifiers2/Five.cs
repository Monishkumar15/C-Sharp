using AccessSpecifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers2
{
    // consuming members of a class from non-child class of different project
    internal class Five
    {
        static void Main(string[] args) 
        {
            Program program = new Program();
            program.Test5(); //Public Method

        }
    }
}
