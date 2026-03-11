using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    // First Create the callback delegate with the same signature of the callback method.
    public delegate void ResultCallbackDelegate(int Results);

    //Creating the Helper class
    public class Number
    {
        //Creating two private variables to hold the Number and ResultCallback instance
        private int _Number;
        private ResultCallbackDelegate _resultCallbackDelegate;

        //Initializing the private variables through constructor
        //So while creating the instance you need to pass the value for Number and callback delegate
        public Number(int Number, ResultCallbackDelegate resultCallbackDelagate)
        {
            _Number = Number;
            _resultCallbackDelegate = resultCallbackDelagate;
        }

        //This is the Thread function which will calculate the sum of the numbers
        public void CalculateSum()
        {
            int Result = 0;
            for (int i = 1; i <= _Number; i++)
            {
                Result = Result + i;
            }

            //Before the end of the thread function call the callback method
            if (_resultCallbackDelegate != null)
            {
                _resultCallbackDelegate(Result);
            }
        }

        static void Main(string[] args)
        {
            //Create the ResultCallbackDelegate instance and to its constructor 
            //pass the callback method name
            ResultCallbackDelegate resultCallbackDelegate = new ResultCallbackDelegate(ResultCallBackMethod);
            int Num = 10;
            //Creating the instance of NumberHelper class by passing the Number
            //the callback delegate instance
            Number obj = new Number(Num, resultCallbackDelegate);
            //Creating the Thread using ThreadStart delegate
            Thread T1 = new Thread(new ThreadStart(obj.CalculateSum));

            T1.Start();
            Console.ReadLine();
        }
        //Callback method and the signature should be the same as the callback delegate signature
        public static void ResultCallBackMethod(int Result)
        {
            Console.WriteLine("The Result is " + Result);
        }
    }
}
