using System;
using System.Collections;

namespace Collections
{
    public class ArrayListDemo
    {
        public static void Main()
        {
            //Adding elements to ArrayList using Add() method
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(101); //Adding Integer Value
            arrayList1.Add("James"); //Adding String Value
            arrayList1.Add(true); //Adding Boolean
            int b = arrayList1.Add(4.5); //Adding double
            //Console.WriteLine(b); return the index value based on insertiom

            //Accessing individual elements from ArrayList using Indexer
            int firstElement = (int)arrayList1[0]; //returns 101
            string secondElement = (string)arrayList1[1]; //returns "James"
            //int secondElement = (int) arrayList1[1]; //Error: cannot cover string to int
            Console.WriteLine($"First Element: {firstElement}, Second Element: {secondElement}");

            //Using var keyword without explicit casting
            var firsItem = arrayList1[0]; //returns 101
            var secondItem = arrayList1[1]; //returns "James"
            //var fifthElement = arrayList1[5]; //Error: Index out of range
            Console.WriteLine($"First Item: {firsItem}, Second Item: {secondItem}");

            //update elements
            arrayList1[0] = "Smith";
            arrayList1[1] = 1010;
            //arrayList1[5] = 500; //Error: Index out of range

            foreach (var item in arrayList1)
            {
                Console.Write($"{item} ");
            }

            //Iterating through for loop
            Console.WriteLine("\n\nUsing For Loop");
            for (int i = 0; i < arrayList1.Count; i++)
            {
                Console.Write($"{arrayList1[i]} ");
            }
            Console.WriteLine("\n");
            //Insert "First Element" at First Position i.e. Index 0
            arrayList1.Insert(0, "First Element");
            //Insert "Third Element" at Third Position i.e. Index 2
            arrayList1.Insert(2, "Third Element");
            //Iterating through foreach loop
            foreach (var item in arrayList1)
            {
                Console.WriteLine($"{item}");
            }


            ArrayList arrayList2 = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Nepal"
            };
            Console.WriteLine("Array List Elements");
            foreach (var item in arrayList2)
            {
                Console.Write($"{item} ");
            }

            ArrayList arrayList3 = new ArrayList()
            {
                    "Srilanka",
                    "Japan",
                    "Britem"
            };
            arrayList2.InsertRange(2, arrayList3);

            Console.WriteLine("\n\nArray List Elements After InsertRange");
            foreach (var item in arrayList2)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
}
