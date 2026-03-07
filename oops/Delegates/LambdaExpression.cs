using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void WelcomeDelegate();
    public class LambdaExpression
    {
        public static void Main()
        {
            WelcomeDelegate welcomeDelegate = () => Console.WriteLine("Warm welcome to all");
            GreetingDelegate obj = name => $"Hello {name} a very Good Evening";
            welcomeDelegate.Invoke();
            string str = obj("Ranveer");
            Console.WriteLine(str);
        }
    }
}
