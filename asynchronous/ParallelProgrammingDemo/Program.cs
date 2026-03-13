using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgrammingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("C# For Loop");
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("C# Parallel For Loop");

            ////It will start from 1 until 10
            ////Here 1 is the start index which is Inclusive
            ////Here 11 us the end index which is Exclusive
            ////Here number is similar to i of our standard for loop
            ////The value will be store in the variable number
            //Parallel.For(1, 11, number => {
            //    Console.WriteLine(number);
            //});

            Console.WriteLine("C# For Loop");
            int number = 10;
            for (int count = 0; count < number; count++)
            {
                //Thread.CurrentThread.ManagedThreadId returns an integer that 
                //represents a unique identifier for the current managed thread.
                Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
                //Sleep the loop for 10 miliseconds
                Thread.Sleep(10);
            }
            Console.WriteLine();

            Console.WriteLine("Parallel For Loop");
            Parallel.For(0, number, count =>
            {
                Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
                //Sleep the loop for 10 miliseconds
                Thread.Sleep(10);
            });
            Console.ReadLine();
        }
    }
}
