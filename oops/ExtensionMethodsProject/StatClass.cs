using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsProject
{
    public static class StatClass
    {
        public static void Test3(this Program p)
        {
            Console.WriteLine("Method 3");
        }
        public static void Test4(this Program p, int i)
        {
            Console.WriteLine("Method 4 value:"+ i);
        }
        public static void Test2(this Program p)
        {
            Console.WriteLine("Method 2 from statclass");
        }
        public static long Factorial(this Int32 x)
        {
            if(x==1)
                return 1;
            if(x==2)
                return 2;
            return x * Factorial(x - 1);
        }

        public static string ToProper(this String oldStr)
        {
            if (oldStr.Trim().Length > 0)
            {
                String NewStr = null;
                oldStr = oldStr.ToLower();
                string[] sarr = oldStr.Split(' ');
                foreach(string st in sarr)
                {
                    char[] ch = st.ToCharArray();
                    ch[0] = Char.ToUpper(ch[0]);
                    if (NewStr == null)
                        NewStr = new String(ch);
                    else
                        NewStr += " "+new String(ch);

                }
                return NewStr;
            }
            return oldStr;

        }
    }
}
