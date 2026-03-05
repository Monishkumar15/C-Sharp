using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticing
{
    public class CopyConstructor
    {
        int x;
        //Parameterized Constructor
        public CopyConstructor(int i)
        {
            x = i;
        }
        //Copy Constructor
        public CopyConstructor(CopyConstructor obj)
        {
            x = obj.x;
        }
        public void Display()
        {
            Console.WriteLine($"Value of X = {x}");
        }
    }
}
