using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charsLeft = new char[] { 'h', 'e', 'l', 'l','o','!',' ','!','@'};
            char[] charsRight = new char[] { ' ', 'R', 'i', 'g','h','t',' ',' ','!'};

            MyString mystrLeft = new MyString(charsLeft);
            mystrLeft.MyPrint();
            MyString mystrRight = new MyString(charsRight);
            mystrRight.MyPrint();
            var isEq = mystrLeft.IsEquals(mystrRight);
            Console.WriteLine($"String is equals? Answer is {isEq}");
            MyString myStringThee = new MyString();
            Console.WriteLine($"Lenght is {myStringThee.Length}");
            myStringThee = mystrLeft.MyConcat(mystrRight);
            Console.WriteLine($"Lenght is {mystrLeft.Length}");
            Console.WriteLine($"Lenght is {myStringThee.Length}");
            myStringThee.MyPrint();
            mystrLeft.MyPrint();
            mystrRight.MyPrint();
            Console.ReadLine();

        }
    }
}
