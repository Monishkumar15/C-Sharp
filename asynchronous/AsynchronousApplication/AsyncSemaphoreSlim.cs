using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousApplication
{
    internal class AsyncSemaphoreSlim
    {
        //Allowing Maximum 3 tasks to be executed at a time
        static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(3);
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            Console.WriteLine($"Main Thread Started");

            //Generating 15 Credit Cards
            List<CreditCard1> CreditCard1s = CreditCard1.GenerateCreditCard1s(15);
            Console.WriteLine($"Credit Card Generated : {CreditCard1s.Count}");

            ProcessCreditCard1s(CreditCard1s);

            Console.WriteLine($"Main Thread Completed");
            Console.ReadKey();
        }

        public static async void ProcessCreditCard1s(List<CreditCard1> CreditCard1s)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var tasks = new List<Task<string>>();

            //Need to use async lambda expression
            tasks = CreditCard1s.Select(async card =>
            {
                await semaphoreSlim.WaitAsync();

                try
                {
                    return await ProcessCard(card);
                }
                finally
                {
                    semaphoreSlim.Release();
                }

            }).ToList();

            //Return the response a string array
            var Responses = await Task.WhenAll(tasks);

            //Creating a collection to hold the responses
            List<CreditCard1Response> CreditCard1Responses = new List<CreditCard1Response>();

            //Looping through the string array
            foreach (var response in Responses)
            {
                //Here, the string is a JSON string
                //Converting the JSON String to .NET Object (CreditCard1Response) using
                //JsonConvert class DeserializeObject
                CreditCard1Response CreditCard1Response = JsonConvert.DeserializeObject<CreditCard1Response>(response);

                //Adding the .NET Object into the resposne collection
                CreditCard1Responses.Add(CreditCard1Response);
            }

            //Printing all the approved credit cards using a foreach loop
            Console.WriteLine("\nApproved Credit Cards");
            foreach (var item in CreditCard1Responses.Where(card => card.IsProcessed == true))
            {
                Console.WriteLine($"Card Number: {item.CardNumber}, Name: {item.Name}");
            }

            //Printing all the rejected credit cards using a foreach loop
            Console.WriteLine("\nRejected Credit Cards");
            foreach (var item in CreditCard1Responses.Where(card => card.IsProcessed == false))
            {
                Console.WriteLine($"Card Number: {item.CardNumber}, Name: {item.Name}");
            }
        }

        public static async Task<string> ProcessCard(CreditCard1 CreditCard1)
        {
            await Task.Delay(1000);

            var CreditCard1Response = new CreditCard1Response
            {
                CardNumber = CreditCard1.CardNumber,
                Name = CreditCard1.Name,

                //Logic to Decide whether the card is processed or rejected
                //If modulus 2 is 0, the processed else rejected
                IsProcessed = CreditCard1.CardNumber % 2 == 0 ? true : false
            };

            //Converting the .NET Object to JSON string
            string jsonString = JsonConvert.SerializeObject(CreditCard1Response);

            //Return the JSON String
            return jsonString;
        }
    }

    public class CreditCard1
    {
        public long CardNumber { get; set; }
        public string Name { get; set; }

        public static List<CreditCard1> GenerateCreditCard1s(int number)
        {
            List<CreditCard1> CreditCard1s = new List<CreditCard1>();
            for (int i = 0; i < number; i++)
            {
                CreditCard1 card = new CreditCard1()
                {
                    CardNumber = 10000000 + i,
                    Name = "CreditCard1-" + i
                };

                CreditCard1s.Add(card);
            }

            return CreditCard1s;
        }
    }

    //This class will hold the response after processing the Credit card
    public class CreditCard1Response
    {
        public long CardNumber { get; set; }
        public string Name { get; set; }
        public bool IsProcessed { get; set; }
    }
}
