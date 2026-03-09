using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class HashTable
    {
         public static void Main(string[] args)
        {
            //Creating Hashtable collection with default constructor
            Hashtable hashtable = new Hashtable();

            //Adding elements to the Hash table using Add method
            hashtable.Add("EId", 1001);
            hashtable.Add("Name", "James");
            hashtable.Add("Location", "Mumbai");

            //Printing All Queue Elements using For Each Loop
            Console.WriteLine("Hashtable Elements:");
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            //Copying the Hashtable to an object array
            DictionaryEntry[] myArray = new DictionaryEntry[hashtable.Count];
            hashtable.CopyTo(myArray, 0);
            Console.WriteLine("\nHashtable Copy Array Elements:");
            foreach (DictionaryEntry item in myArray)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Object[] myObjArrayKey = new Object[hashtable.Count];
            Object[] myObjArrayValue = new Object[hashtable.Count];
            Console.WriteLine("\nCopyTo Method to Copy Keys:");
            hashtable.Keys.CopyTo(myObjArrayKey, 0);
            foreach (var key in myObjArrayKey)
            {
                Console.WriteLine($"{key} ");
            }
            Console.WriteLine("myObjArrayKey is a fixedSize: " + myObjArrayKey.IsFixedSize);
            Console.WriteLine("hashtable is a fixedSize: " + hashtable.IsFixedSize);

            Console.WriteLine("\nCopyTo Method to Copy Values:");
            hashtable.Values.CopyTo(myObjArrayValue, 0);
            foreach (var key in myObjArrayValue)
            {
                Console.WriteLine($"{key} ");
            }

            Console.WriteLine("IsReadOnly: " + hashtable.IsReadOnly);
            Console.WriteLine("Issynchronized: " + hashtable.IsSynchronized);
            lock (hashtable.SyncRoot)
            {

            Console.WriteLine("SyncRoot in lock: " + hashtable.SyncRoot);
            }
            Console.WriteLine("SyncRoot: " + hashtable.SyncRoot);

            Console.ReadKey();
        }
    }
}
