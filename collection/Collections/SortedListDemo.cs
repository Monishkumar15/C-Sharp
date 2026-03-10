using System;
using System.Collections;

namespace Collections
{
    public class SortedListDemo
    {
        public static void Main(string[] args)
        {
            //Creating sortedList Collection
            SortedList sortedList = new SortedList();

            //Adding Elements to SortedList using Add Method
            //Key type going to be same
            sortedList.Add(1, "One");
            sortedList.Add(5, "Five");
            sortedList.Add(4, "Four");
            sortedList.Add(2, "Two");
            sortedList.Add(3, "Three");

            //Duplicate Key not allowed
            //System.ArgumentException: 'Item has already been added. Key in dictionary: '4'  Key being added: '4''
            //sortedList.Add(4, "Four");

            //Null value is allwed
            sortedList.Add(6, null);

            //Duplicate Value is allowed
            sortedList.Add(7, "Five");

            //In this case string key is not valid, throw Exception
            //sortedList.Add("Ten", "Ten");

            //Accessing SortedList using For loop
            Console.WriteLine("Accessing SortedList using For loop");
            for (int x = 0; x < sortedList.Count; x++)
            {
                Console.WriteLine($"Key: {sortedList.GetKey(x)}, Value: {sortedList.GetByIndex(x)}");
            }

            Console.WriteLine("\nAccessing SortedList using For Each loop");
            //Accessing SortedList using For Each loop
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Console.WriteLine("\nAccessing SortedList using Keys");
            Console.WriteLine($"Key: 1, Value: {sortedList[1]}");
            Console.WriteLine($"Key: 2, Value: {sortedList[2]}");
            Console.WriteLine($"Key: 3, Value: {sortedList[3]}");

            Console.WriteLine("\nAccessing SortedList using Index");
            Console.WriteLine($"Key: 1, Index: 0, Value: {sortedList.GetByIndex(0)}");
            Console.WriteLine($"Key: 2, Index: 1, Value: {sortedList.GetByIndex(1)}");
            Console.WriteLine($"Key: 3, Index: 2, Value: {sortedList.GetByIndex(2)}");

            Console.ReadKey();
        }
    }
}
