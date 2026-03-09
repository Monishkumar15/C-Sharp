using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class SortedListCopy
    {
        public static void Main(string[] args)
        {
            //Creating sortedList using Object Initializer
            SortedList sortedList = new SortedList
            {
                { "Ind", "India" },
                { "USA", "United State of America" },
                { "SA", "South Africa" },
                { "PAK", "Pakistan" }
            };

            Console.WriteLine("Sorted List Elements:");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key} : Value: {item.Value}");
            }

            DictionaryEntry[] myTargetArray = new DictionaryEntry[5];
            sortedList.CopyTo(myTargetArray, 1);
            Console.WriteLine("\nCopyTo Method to Copy Keys and values:");
            for (int i = 0; i < myTargetArray.Length; i++)
            {
                Console.WriteLine($"{myTargetArray[i].Key} : {myTargetArray[i].Value}");
            }

            Object[] myObjArrayKey = new Object[5];
            Object[] myObjArrayValue = new Object[5];

            Console.WriteLine("\nCopyTo Method to Copy Keys:");
            sortedList.Keys.CopyTo(myObjArrayKey, 0);
            foreach (var key in myObjArrayKey)
            {
                Console.WriteLine($"{key} ");
            }

            Console.WriteLine("\nCopyTo Method to Copy Values:");
            sortedList.Values.CopyTo(myObjArrayValue, 1);
            foreach (var key in myObjArrayValue)
            {
                Console.WriteLine($"{key} ");
            }
            ArrayList arrayList1 = new ArrayList { 1,2,3,4  };
            ArrayList arrayList2 = new ArrayList{5,6,7,8};
            List<ArrayList> obj = new List<ArrayList>();
            obj.Add(arrayList1);
            obj.Add(arrayList2);
            Console.WriteLine(arrayList1.ToString());
            Console.WriteLine(string.Join(",", arrayList1.ToArray()));
            Console.WriteLine(string.Join(",", arrayList2.ToArray()));
            Console.WriteLine(arrayList2.ToString());
            Console.WriteLine(obj.ToString());
            Console.ReadKey();
        }
    }
}
