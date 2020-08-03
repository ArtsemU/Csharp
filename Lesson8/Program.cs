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
            var x = mystrLeft.MyLength;
			Console.WriteLine(x);
			Console.WriteLine(mystrLeft[2]);
			mystrLeft.MyPrint();
			MyString mystrRight = new MyString(charsRight);
			mystrRight.MyPrint();
			var isEq = mystrLeft.IsEquals(mystrRight);
			Console.WriteLine($"String is equals? Answer is {isEq}");
			var indexSpace = mystrLeft.MyIndexOf(' ', 4);
			Console.WriteLine(indexSpace);

			Console.ReadLine();

        }
    }
}
