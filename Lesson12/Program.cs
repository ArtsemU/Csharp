using System;

namespace Lesson12
{
	class Program
	{
		delegate void MyDelegate();


		static void Main(string[] args)
		{
			Console.WriteLine("\t\t\tDelegate, lambda, events");

			MyDelegate myDel = Hello;
			myDel?.Invoke();
			myDel -= Hello;
			if (myDel == null)
			{
				Console.WriteLine("Empty delegate");
			}
			else Console.WriteLine("Not empty");
			myDel += Hello;
			myDel += Hello;
			myDel += Hello;
			myDel += Question;

			myDel();
			Console.WriteLine(myDel.Method);


			Console.ReadLine();
		}

		static void Hello()
		{
			Console.WriteLine("Hello my dear!");
		}
		static void Question()
		{
			Console.WriteLine("Who you are??");
		}
	}
}
