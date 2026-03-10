using System;
using System.Collections;

namespace Collections
{
    public class ArrayListDemo2
    {
        public static void Main()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Nepal",
                    "HongKong",
                    "Srilanka",
                    "Japan",
                    "Britem",
                    "HongKong",
            };
            Console.WriteLine("Array List Elements");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            arrayList.Remove("HongKong"); //Removes first occurance of null
            Console.WriteLine("\n\nArray List Elements After Removing First Occurances of HongKong");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            arrayList.RemoveAt(3); //Removes element at index postion 3, it is 0 based index
            Console.WriteLine("\n\nArray List1 Elements After Removing Element from Index 3");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            arrayList.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
            Console.WriteLine("\n\nArray List Elements After Removing First Two Elements");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }

            int totalItems = arrayList.Count;
            Console.WriteLine(string.Format($"\nTotal Items: {totalItems}, Capacity: {arrayList.Capacity}"));
            //Remove all items from the Array list             
            arrayList.Clear();
            totalItems = arrayList.Count;
            Console.WriteLine(string.Format($"Total Items After Clear(): {totalItems}, Capacity: {arrayList.Capacity}"));

            Console.ReadKey();
        }
    }
}
