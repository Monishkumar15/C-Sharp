using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Matrix
    {
        int a, b, c, d;
        public Matrix(int a,int b, int c, int d) {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix obj = new Matrix(m1.a+m2.a, m1.b+m2.b, m1.c+m2.c, m1.d+m2.d);
            return obj;
        }
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            Matrix obj = new Matrix(m1.a-m2.a, m1.b-m2.b, m1.c-m2.c, m1.d-m2.d);
            return obj;
        }
        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            Matrix obj = new Matrix(m1.a*m2.a, m1.b*m2.b, m1.c*m2.c, m1.d*m2.d);
            return obj;
        }
        public static Matrix operator /(Matrix m1, Matrix m2)
        {
            return new Matrix(m1.a/m2.a, m1.b/m2.b, m1.c/m2.c, m1.d/m2.d);
        }

        public override string ToString()
        {
            return $"{this.a} {this.b}\n{this.c} {this.d}\n";
        }
    }
    class MatrixMain
    {
        public static void Main()
        {
            Matrix m1 = new Matrix(10, 20, 30, 40);
            Matrix m2 = new Matrix(4, 5, 3, 2);
            Matrix m3 = m1 + m2;
            Matrix m4 = m1 - m2;
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);

            Matrix m5 = m3 * m4;
            Matrix m6 = m5 / m2;
            Console.WriteLine(m5);
            Console.WriteLine(m6);
            Console.ReadLine();
        }
    }

}
