using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Logger
    {
        public static void Log(string ClassName, string MethodName, string Message)
        {
            Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, ClassName: {ClassName}, MethodName:{MethodName}, Message:{Message}");
        }
        public static void Log(string uniqueId, string ClassName, string MethodName, string Message)
        {
            Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, UniqueId: {uniqueId}, ClassName: {ClassName}, MethodName:{MethodName}, Message:{Message}");
        }
        public static void Log(string Message)
        {
            Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, Message: {Message}");
        }
        public static void Log(string ClassName, string MethodName, Exception ex)
        {
            Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, ClassName: {ClassName}, MethodName:{MethodName}, Exception Message:{ex.Message}, \nException StackTrace: {ex.StackTrace}");
        }
    }

    class LoggerDriver
    {
        static void Main(string[] args)
        {
            string ClassName = "LoggerDriver";
            string MethodName = "Main";
            string UniqueId = Guid.NewGuid().ToString();
            Logger.Log(ClassName, MethodName, "Message 1");
            Logger.Log(UniqueId, ClassName, MethodName, "Message 2");
            Logger.Log("Message 3");

            try
            {
                int Num1 = 10, Num2 = 0;
                int result = Num1 / Num2;
                Logger.Log(UniqueId, ClassName, MethodName, "Message 4");
            }
            catch (Exception ex)
            {
                Logger.Log(ClassName, MethodName, ex);
            }

            Console.ReadKey();
        }
    }

}
