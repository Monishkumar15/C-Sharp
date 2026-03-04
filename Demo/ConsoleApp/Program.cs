using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Data Types practice");
            byte byteData;
            short shortData;
            int integerData;
            long longData;
            float floatData;
            double doubleData;
            char charData;
            string stringData;
            bool boolData;

            byteData = Byte.MaxValue;
            shortData = 6743;
            integerData = 82346295;
            longData = 999996369265992;
            floatData = 23;
            doubleData = 6564.5487;
            charData = 'z';
            stringData = "Hello";
            boolData = false;
            Console.WriteLine("Byte Data : "+byteData);
            Console.WriteLine("Short Data : " + shortData);
            Console.WriteLine("Integer Data : " + integerData);
            Console.WriteLine("Long Data : " + longData);
            Console.WriteLine("Float Data : " + floatData);
            Console.WriteLine("Double Data : " + doubleData);
            Console.WriteLine("Char Data : " + charData);    
            Console.WriteLine("String Data : " + stringData);  
            Console.WriteLine("Bool Data : " + boolData);


            TypeCasting type = new TypeCasting();
            Console.WriteLine( type.GetType());
            Console.WriteLine(type.ToString());
            TypeCasting.Type();

            //Console.WriteLine("Enter the Input value:");
            //int input = int.Parse(Console.ReadLine());
            //Console.WriteLine(input);

            //Console.WriteLine("Enter the Input value2:");
            //int input1 = Convert.ToInt32((Console.ReadLine()));
            //Console.WriteLine(input1);

            int[] arr = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(arr);
            Console.WriteLine(arr.ToString());
            Array.Sort(arr);

            /*int[,] numbers =
            {
                {1,2,3,4 },
                {5,6,7,8 }
            };
            numbers[0, 0] = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j]);

                }
                Console.WriteLine();
            }


            int[][] jag =
            {
                new int[]{1,2,3 },
                new int[] {4,5 },
                new int[] {6,7,8,9 }
            };

            for(int i=0; i<jag.Length; i++)
            {
                for (int j=0; j < jag[i].Length; j++)
                {
                    Console.Write(jag[i][j]);
                }
                Console.WriteLine() ;
            }
    */
            //Console.Beep(500,5000);
            //Console.Beep(1000,1000);
            //Console.Beep(1500,1000);
            //Console.Beep(2000,1000);


            //Console.WriteLine("Enter a Key");
            //int var1 = Console.Read();
            //Console.WriteLine($"ASCII Value of the Entered Key is: {var1}");

            //Console.WriteLine("Enter Another Key");
            //ConsoleKeyInfo var2 = Console.ReadKey();
            //Console.WriteLine($"\nEntered Key: {var2.Key} KeyChar:{var2.KeyChar} ASCII:{(int)var2.KeyChar}");


            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Title = "Understanding Console Class";
            //Console.WriteLine("BackgroundColor: Blue");
            //Console.WriteLine("ForegroundColor: White");
            //Console.WriteLine("Title: Understanding Console Class");

            Employee employee = new Employee();
            employee.findEmployee();


            int a = 15;
            UpdateValue(ref a);
            Console.WriteLine(a);


            //Console.WriteLine($"First Command Line Argument {args[0]}");
            //Console.WriteLine($"Second Command Line Argument {args[1]}");
            //Console.WriteLine($"Third Command Line Argument {args[2]}");

            string a1 = "Hello";
            string b = "Hello";

            Console.WriteLine(object.ReferenceEquals(a1, b));
            Program program = new Program();
            //program.Hello();
            program.ToString();


            int int1 = 10;
            Int32 int2 = int1;
            Console.WriteLine($"int1 : {int1} , int2 : {int2}");

            bool bool1 = true;
            Boolean bool2 = bool1;
            Console.WriteLine($"bool1: {bool1} , bool2: {bool2}");

            Console.WriteLine("Press Any Key to Terminate");
            Console.ReadKey();
        }

        static void UpdateValue(ref int b)
        {
            b = 30;
        }
        void Hello()
        {
            Console.WriteLine("Hello method");
            Hi();
        }
        static void Hi()
        {
            Console.WriteLine("Hi method");
        }
    }
}
