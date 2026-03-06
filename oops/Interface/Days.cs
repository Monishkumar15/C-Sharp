using System;

namespace Interface
{
    public enum Days
    {
        Monday = 1,
        Tuesday = 11,
        Wednesday = 22,
        Thursday = 33,
        Friday = 44,

    }
    public class TestClass
    {

        public static Days MeetingDate
        {
            get; set;
        } = (Days)1;
        //public static Days MeetingDate
        //{
        //    get; set;
        //} = 1; Cannot implicitly convert type 'int' to 'Interface.Days'. An explicit conversion exists (are you missing a cast?)
        static void Main()
        {
            foreach(int i in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(i);
            }

            foreach(string i in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(i);
            }
            foreach(int i in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(i+" : "+(Days)i);
            }

            Console.WriteLine(MeetingDate);
            MeetingDate = Days.Wednesday;
            Console.WriteLine(MeetingDate);
            Console.ReadLine();
        }
    }
}