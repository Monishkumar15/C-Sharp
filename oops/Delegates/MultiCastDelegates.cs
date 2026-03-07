using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class MultiCastDelegates
    {
    delegate void RectDelegate(double Width, double Height);
        public MultiCastDelegates() { }
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area of rectangle: " + Width * Height);
        }

        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter of reactangle: "+ 2*(Width+Height));
        }

        static void Main()
        {
            MultiCastDelegates rectangle = new MultiCastDelegates();
            rectangle.GetArea(12.34, 56.64);
            rectangle.GetPerimeter(6.34, 18.31);
            Console.WriteLine();
            
            //Multicast delegates
            RectDelegate obj = new RectDelegate(rectangle.GetArea);
            obj += rectangle.GetPerimeter;

            Console.WriteLine("Multicast Delegate Invoke approach");
            obj.Invoke(43.32, 75.1);
            Console.WriteLine();

            //Without using new keyword
            RectDelegate rect = rectangle.GetPerimeter;
            rect += rectangle.GetArea;
            rect(23, 43);
            Console.ReadLine();
        }

    }
}
