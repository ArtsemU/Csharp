using F_HomeTask;
using System;

namespace HomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "Hello!";
            Console.WriteLine(testString);
            Console.WriteLine(MarkString(testString));
        }
        public static string MarkString(string coverString)
        {
            string ss = "";
            for (int i = 0; i < coverString.Length; i++)
            {
                ss = ss + "_";
            }
            return ss;
        }
    }
}
