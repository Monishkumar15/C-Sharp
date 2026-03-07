using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //If delegate return the multiple method return types last method return value only you get as response
    public class MultiCastDelegates2
    {
        delegate double RectDelegate(double Width, double Height);
        public MultiCastDelegates2() { }
        public double GetArea(double Width, double Height)
        {
            return  (Width * Height);
        }

        public double GetPerimeter(double Width, double Height)
        {
            return ( 2 * (Width + Height));
        }

        static void Main()
        {
            MultiCastDelegates2 rectangle = new MultiCastDelegates2();
            Console.WriteLine(rectangle.GetArea(12.34, 56.64));
            Console.WriteLine(rectangle.GetPerimeter(6.34, 18.31));
            Console.WriteLine();

            //Multicast delegates
            RectDelegate obj = new RectDelegate(rectangle.GetArea);
            obj += rectangle.GetPerimeter;

            Console.WriteLine("Multicast Delegate Invoke approach");
            double res = obj.Invoke(43.32, 75.1);
            Console.WriteLine(res);
            Console.WriteLine();

            //Without using new keyword
            RectDelegate rect = rectangle.GetPerimeter;
            rect += rectangle.GetArea;
            Console.WriteLine(rect(23, 43));

            Console.ReadLine();
        }
        }
}
