using System;

namespace ExtraLesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Building palindromes");

            string palindromeString = "aA bbc c BBaa";

            string palindromeStringNew = palindromeString.Replace(" ", "").ToLower();
            Console.WriteLine(palindromeStringNew);
            string palindromeStringCheck = "";
            for (int i = palindromeStringNew.Length-1; i >= 0; i--)
            {
                palindromeStringCheck += palindromeStringNew[i];
            }
            Console.WriteLine(palindromeStringCheck);

            if (palindromeStringCheck.Equals(palindromeStringNew))
            {
                Console.WriteLine("Next string is palindrome:");
                Console.WriteLine(palindromeString);
            }
            else
            {
                Console.WriteLine("Sorry! But next string is not a palindrome");
                Console.WriteLine(palindromeString);
            }
            Console.ReadLine();
        }
    }
}
