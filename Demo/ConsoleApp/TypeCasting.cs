using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class TypeCasting

    {
        public static void Type()
        {
            string input = "50";
            int result ;

            bool isValid = int.TryParse(input, out  result);

            if (isValid)
            {
                Console.WriteLine("Converted: " + result);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
