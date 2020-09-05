using System;
using System.Collections.Generic;
using System.Linq;

namespace ForPlaying
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();

            //myList.Add("first item");
            //myList.Add("second item");
            //myList.Add("3th item");
            try
            {
                var x = myList.First();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            //Console.WriteLine(x);
        }
    }
}
