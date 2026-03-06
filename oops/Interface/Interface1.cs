using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface Interface1
    {
        void Test();
        void Show();
    }

    public interface Interface2
    {
        void Test();
        void Show();
    }

    class MultipleInheritanceClass : Interface1, Interface2
    {

        //Normal Implementation
        public void Show()
        {
            Console.WriteLine("Interfaces method show method implemented in child class");
        }


        //Explicity Implementation
        void Interface1.Test()
        {
            Console.WriteLine("Declared in Interface1 and implemented in child class");
        }

        void Interface2.Test()
        {
            Console.WriteLine("Declared in Interface2 and implemented in child class");
        }

        public static void Main()
        {
            MultipleInheritanceClass m = new MultipleInheritanceClass();
            m.Show();
            //m.Test(); 'MultipleInheritanceClass' does not contain a definition for 'Test' and no accessible extension method 'Test' accepting a first argument of type 'MultipleInheritanceClass' could be found

            Interface1 i1 = new MultipleInheritanceClass();
            i1.Show();
            i1.Test();

            Interface2 i2 = new MultipleInheritanceClass();
            i2.Show();
            i2.Test();
        }
    }
}
