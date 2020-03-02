using System;
using System.Text;

namespace CSharpCource
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void variables() {
            int x = -1;
            int y;
            y = x + 2;
            // System.Int32 z = 1;
            float z = 1.1f;
            double z1 = 1.1;
            int x2 = 0;
            int x3 = new int();
            var a = 1;
            decimal c1 = 3.2m;
            char ch = 'b';
            string s = "sss";
            //   string s1 = 'ss';

            bool t = true;
            bool t1 = false;
            bool t2;
            object o1 = 1;
            object o2 = "awd";


            Console.WriteLine(x3);
            Console.WriteLine("This is Grount Control");
        }

        static void incrDecrDemo() {
            int x = 1;
            Console.WriteLine(x);
            x++;
            Console.WriteLine(x);
            x--;

            Console.WriteLine("- - - - - - -");
            int j = x++;
            Console.WriteLine(j);
            Console.WriteLine(x);
            j = ++x;
            Console.WriteLine(j);
            Console.WriteLine(x);

            x += 2;
            Console.WriteLine(x);
            x -= 2;
            Console.WriteLine(x);
        }

        static void plusMinusAndCo()
        {
            int x = 1;
            int z = 3;
            int k = 2;

            int c = z / k;
            Console.WriteLine(c);
            Console.WriteLine(5 / 2);

            // остаток от деления
            int a = 4 % 2;
            int b = 5 % 2;
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = 3;
            a = a * a;
            Console.WriteLine(a);
            a *= 2;
            Console.WriteLine(a);
        }

        static void stringTheme() {

            string str = string.Empty; // same as ""
            string name = "abracadabra";
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('e');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            bool endsWithAbra = name.EndsWith("abra");
            Console.WriteLine(endsWithAbra);

            bool starWithAbra = name.StartsWith("abra");
            Console.WriteLine(starWithAbra);

            int indexOfA = name.IndexOf('a', 1);
            Console.WriteLine(indexOfA);

            int lastIndexOfA = name.LastIndexOf('r');
            Console.WriteLine(lastIndexOfA);

            Console.WriteLine(name.Length);

            string substrfrom5 = name.Substring(5);
            Console.WriteLine(substrfrom5);

            string substrFromTo = name.Substring(0, 3);
            Console.WriteLine(substrFromTo);

            Console.WriteLine("- - - - Emty strings - - - - - - ");

            string empty = "";
            string withSpace = " ";
            string notEmpty = " b";
            string nullString = null;

            Console.WriteLine("IsNullOrEmpty");
            bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(withSpace);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrEmpty);

            Console.WriteLine();
            Console.WriteLine("- - - - Is null or wite space - - - - ");

            bool isNullOrWitheSpace = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(isNullOrWitheSpace);

            isNullOrWitheSpace = string.IsNullOrWhiteSpace(withSpace);
            Console.WriteLine(isNullOrWitheSpace);

            isNullOrWitheSpace = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(isNullOrWitheSpace);

            isNullOrWitheSpace = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(isNullOrWitheSpace);



        }

        static void stringConcatJoinSplit() {
            string nameConcat = string.Concat("My", " ", "name is ", "John");
            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ", "My", "name", "is", "John");
            Console.WriteLine(nameConcat);

            //string newName = 
            nameConcat = nameConcat.Insert(0, "By the way, ");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Remove(0, 1);
            Console.WriteLine(nameConcat);

            string replaced = nameConcat.Replace('n', 'Z');
            Console.WriteLine(replaced);

            string data = "12;28;34;25;64";
            string[] splitData = data.Split(';');
            Console.WriteLine(splitData);
            string first = splitData[0];
            Console.WriteLine(first);

            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]);

            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);

            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            string john = " My name is John ";
            Console.WriteLine(john.Trim());
        }

        static void stringBuilder() {
            //string builder

            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John");
            sb.AppendLine("!");
            sb.Append("Hello");


            string str = sb.ToString();
            Console.WriteLine(str);
        }

        static void stringFormatting() {
            // string formating

            string name = "John";
            int age = 30;
            string str1 = string.Format("My name is {0} and I'm {1}", name, age);
            string str2 = $"My name is {name} and I'm {age}";
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            string str3 = "My name \tis \n John";
            Console.WriteLine(str3);

            string str4 = $"My name is {Environment.NewLine} John"; // более универсальный способ. сработает во всех ОС
            Console.WriteLine(str4);

            //экранирование
            string str5 = "I'm John and I am a \"good\" QA";
            Console.WriteLine(str5);
            string str6 = "C:\\save10\\111";
            Console.WriteLine(str6);

            string str7 = @"C:\tmp\111.txt";
            Console.WriteLine(str7);

            int answer = 42;
            string result = string.Format("{0:d}", answer);
            string result2 = string.Format("{0:d4}", answer);
            Console.WriteLine(result);
            Console.WriteLine(result2);

            result = string.Format("{0:f}", answer);
            result2 = string.Format("{0:f4}", answer);
            Console.WriteLine(result);
            Console.WriteLine(result2);

            double money = 12.08;
            result = string.Format("{0:C}", money);
            result2 = string.Format("{0:C2}", money);
            Console.WriteLine(result);
            Console.WriteLine(result2);

            result = $"{money:C2}";
            Console.WriteLine(result);
            Console.WriteLine(money.ToString("C2"));
        }

        static void stringCompare() {
            string str1 = "abcde";
            string str2 = "abcde";

            bool areEqual = str1 == str2;
            Console.WriteLine(areEqual);

            areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(areEqual);

            string s1 = "Strasse";
            string s2 = "Straße";
            areEqual = string.Equals(s1, s2, StringComparison.Ordinal);
            Console.WriteLine(areEqual);
            areEqual = string.Equals(s1, s2, StringComparison.InvariantCulture);
            Console.WriteLine(areEqual);
            areEqual = string.Equals(s1, s2, StringComparison.CurrentCulture);
            Console.WriteLine(areEqual);
        }

        static void workWithConcole() {
            Console.WriteLine("Hi! please tell me your name");

            string name = Console.ReadLine();
            string sentence = $"Your name is {name}";
            Console.WriteLine(sentence);

            Console.WriteLine("Please tell me your age");
            string age = Console.ReadLine();
            string yourAge = $"Your age is {age}";
            Console.WriteLine(yourAge);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write("Hello!");
            Console.Write("Hello!");
        }

        static void moveIntToFloatAndComments() {
            byte b = 3;
            int i = b;
            long l = i;

            float f = i;

            i = (int)f;
            Console.WriteLine(i);

            string str = "1";
            i = int.Parse(str);
            Console.WriteLine(i);

            //  - - - Comments - - -

            // One line

            /*
             * Multy Line Comment
             * 
             */
            // describe how and why!! now what!
        }

        static void math() {
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.E);
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Sqrt(5));

            Console.WriteLine(Math.Round(1.7));
            Console.WriteLine(Math.Round(1.4));
            Console.WriteLine(Math.Round(1.5));

            Console.WriteLine();
            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));

        }

        static void arraysSimple() {
            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 6, 7, -1, 0 };

            int[] a4 = { 2, 6, -1, 0, 2 };

            Console.WriteLine(a4[2]);
            a4[2] = 99;
            Console.WriteLine(a4[2]);

            int number = a3[2];
            Console.WriteLine(number);
            Console.WriteLine(a2[2]);

            Console.WriteLine(a1.Length);
        }

        static void dateAndTime() {
            // date time

            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.Year);

            DateTime dt = new DateTime(2016, 10, 24);
            Console.WriteLine(dt);
            DateTime newDt = dt.AddDays(-1);
            Console.WriteLine(newDt);

            TimeSpan ts = now - dt;
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.TotalDays);
            Console.WriteLine(ts.Ticks);
            //ts = now.Subtract(dt);
        }

        static void firstExersic()
        {  //1 
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");

            //2
            Console.WriteLine();
            Console.WriteLine("Please enter first number:");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"First number is {a1}, second number is {a2}");
            int a3 = a1;
            a1 = a2;
            a2 = a3;
            Console.WriteLine(" !!! Magic !!!");
            Console.WriteLine($"First number is {a1}, second number is {a2}");

            //3
            Console.WriteLine();
            Console.WriteLine("Please enter some number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number.ToString().Length);
        }

        static void secondEx()
        {
            Console.WriteLine("Enter 1st side:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2st side:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3st side:");
            double c = double.Parse(Console.ReadLine());
            double p = (a + b + c) / 2;
            Console.WriteLine($"p={p}");

            if ((a + b > c) & (a + c > b) & (c + b > a))
            {
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"Square is {s:f4}");
            }
            else
            {
                Console.WriteLine("sorry... not a triangle");
            }
        }

        static void lastEx()
        {
            Console.WriteLine("Enter your family");
            string family = Console.ReadLine();
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            double age = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your weight");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height in meter");
            double height = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height);

            string result = string.Format("Your profile:\nFull name {0}, {1}\nAge: {2}\nWeight: {3}\nHeight: {4}\nBody Mass Index: {5:f2}",
               family, name, age, weight, height, bmi);
            Console.WriteLine();
            Console.WriteLine(result);
        }

    }
}
