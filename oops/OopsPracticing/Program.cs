using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticing
{
    public class Program
    {
    const float PI= 3.14f;
        Program() {
            Console.WriteLine("Program class");
        }

        static void Main(string[] args)
        {
            Calculator calObject = new Calculator();

            //Accessing Calculator class member using Calculator class object
            int result = calObject.CalculateSum(10, 20);

            Console.WriteLine(result);
            Console.WriteLine(PI);

            CopyConstructor obj1 = new CopyConstructor(10);
            obj1.Display();
            CopyConstructor obj2 = new CopyConstructor(obj1);
            obj2.Display();
            StaticConstructor obj3 = new StaticConstructor();


            Constructor c1 = new Constructor();
            Constructor c2 = new Constructor();
            Constructor c3 = new Constructor();
            Console.WriteLine($"{c1.x}  {c2.x}  {c3.x}");

            Second s1 = new Second(100); //100 will send to local variable x
            Second s2 = new Second(200); //200 will send to local variable x
            Second s3 = new Second(300); //300 will send to local variable x
            Console.WriteLine($"{s1.x}   {s2.x}   {s3.x}");

            ConstructorsDemo obj = new ConstructorsDemo(1);

            //As soon as it finds ConstructorsDemo.x, 
            //it will first execute the static constructor of the class
            Console.WriteLine(ConstructorsDemo.x);


            //Creating instance of Child class
            Parent.Child child = new Parent.Child();

            //Singleton Class create object

            Singleton fromPlace1 = Singleton.GetSingletonInstance();
            fromPlace1.SomeMethod("From Place 1");
            Singleton fromPlace2 = Singleton.GetSingletonInstance();
            fromPlace2.SomeMethod("From Place 2");


            DestructorDemo dest1 = new DestructorDemo();
            DestructorDemo dest2 = new DestructorDemo();
            //Making dest1 and dest2 ready for Garbage Collection
            dest1 = null;
            dest2 = null;
            GC.Collect();


            DestructorDemo dest3 =null;
            Convert.ToString(dest3);
            //dest3.ToString();  To get //System.NullReferenceException: 'Object reference not set to an instance of an object.' dest3 was null.

            String Name = null;
            Convert.ToString(Name);
            Console.WriteLine("No Error");


            //Dispose Pattern in C#:
            UmmanagedResource resource = null;
            try
            {
                resource = new UmmanagedResource();
                Console.WriteLine("Using Resources");
            }
            finally
            {
                if (resource != null)
                {
                    Console.WriteLine("Calling Dispose Method to Destroy Resources");
                    resource.Dispose();
                }
            }

            //Trying to Call the Dispose Method again
            Console.WriteLine();
            Console.WriteLine("Trying to Call the Dispose Method Again To Destroy Resources");
            resource.Dispose();



            Console.WriteLine("*********************Dispose()**********************************");
            // Using the ResourceHolder with using statement
            // C# supports the using statement to automatically call Dispose() when a scope ends. This pattern simplifies resource management and reduces leaks.
            using (var resourceHolder = new ResourceHolder())
            {
                // Use the resource...
            } // Dispose is called automatically when exiting the using block.

            // If not using 'using', dispose should be called manually.
            var anotherResourceHolder = new ResourceHolder();
            // Use the resource...
            anotherResourceHolder.Dispose();

            // Without calling Dispose, finalizer will be called by GC at some point.
            var finalResourceHolder = new ResourceHolder();
            // Use the resource...
            finalResourceHolder = null;
            GC.Collect();

            Console.ReadKey();
        }
    public void Demo()
        {
            Console.WriteLine(PI);
        }
    }

}

    //Defining class or blueprint or template
    public class Calculator
    {

        public Calculator()
        {
            Console.WriteLine("Calculator class");
        }
        public int CalculateSum(int no1, int no2)
        {
            return no1 + no2;
        }
    }
public class StaticConstructor
{
    static StaticConstructor()
    {
        Console.WriteLine("Static Constructor Executed!");
    }
}

public sealed class Singleton
{
    private static int counter = 0;
    private static Singleton instance = null;
    private static readonly object Instancelock = new object();
    public static Singleton GetSingletonInstance()
    {
        lock (Instancelock)
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
    private Singleton()
    {
        counter++;
        Console.WriteLine($"Singleton Constructor Executed {counter} Time");
    }
    public void SomeMethod(string Message)
    {
        Console.WriteLine($"Some Method Called : {Message}");
    }
}


class DestructorDemo
{
    public DestructorDemo()
    {
        Console.WriteLine("Constructor Object Created");
    }
    ~DestructorDemo()
    {
        string type = GetType().Name;
        Console.WriteLine($"Object {type} is Destroyed");
    }
}