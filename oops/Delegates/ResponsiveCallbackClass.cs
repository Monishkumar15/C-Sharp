using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class ResponsiveCallbackClass
    {
        delegate void ResponseDelegate(string result);
        static void ProcessData(ResponseDelegate response)
        {
            // simulate processing
            string data = "Processing completed";
            response(data); // send response back
        }

        static void ShowResult(string message)
        {
            Console.WriteLine(message);
        }

        static void Main()
        {
            ProcessData(ShowResult);
        }
    }
}
