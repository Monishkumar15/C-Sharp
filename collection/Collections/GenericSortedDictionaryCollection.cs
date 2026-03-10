using System;
using System.Collections.Generic;

namespace Collections
{
    public class GenericSortedDictionaryCollection
    {
        static void Main()
        {
            //Here we are creating a genericSortedDictionary whose key is int and value is Student
            SortedDictionary<int, Student> genericSortedDictionary = new SortedDictionary<int, Student>
            {
                { 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"} },
                { 104, new Student(){ ID = 104, Name ="Pranaya", Branch="ETC"}},
                { 103, new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}},
                { 102, new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"}}
            };

            //Accessing Generic genericSortedDictionary Collection using For Each loop
            Console.WriteLine("Generic genericSortedDictionary Elements");
            foreach (KeyValuePair<int, Student> item in genericSortedDictionary)
            {
                Console.WriteLine($"Key: {item.Key}: ID: {item.Value.ID}, Name: {item.Value.Name}, Branch: {item.Value.Branch}");
            }

            Student? std102;
            if (genericSortedDictionary.TryGetValue(102, out std102))
            {
                Console.WriteLine("\nStudent with Key = 102 is found in the SortedDictionary");
                Console.WriteLine($"ID: {std102.ID}, Name: {std102.Name}, Branch: {std102.Branch}");
            }
            else
            {
                Console.WriteLine("\nStudent with Key = 102 is not found in the SortedDictionary");
            }

            Student? std115;
            if (genericSortedDictionary.TryGetValue(105, out std115))
            {
                Console.WriteLine("\nStudent with Key = 102 is found in the SortedDictionary");
                Console.WriteLine($"ID: {std115.ID}, Name: {std115.Name}, Branch: {std115.Branch}");
            }
            else
            {
                Console.WriteLine("\nStudent with Key = 105 is not found in the SortedDictionary");
            }

            Console.ReadKey();
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
    }
}
