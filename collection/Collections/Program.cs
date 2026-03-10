using System;
using System.Collections;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Adding elements to ArrayList using Add() method
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(101); //Adding Integer Value
            arrayList1.Add("James"); //Adding String Value
            arrayList1.Add("James"); //Adding Duplicate Value
            arrayList1.Add(" "); //Adding Empty
            arrayList1.Add(true); //Adding Boolean
            arrayList1.Add(4.5); //Adding double
            arrayList1.Add(null); //Adding null
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            //Adding Elements to ArrayList using object initializer syntax
            var arrayList2 = new ArrayList()
            {
                102, "Smith", "Smith", true, 15.6
            };
            foreach (var item in arrayList2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
