using System;

namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void operatorIf() {
            Console.WriteLine("Enter your age");
            double age = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your weight");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height in meter");
            double height = double.Parse(Console.ReadLine());

            double bodyMassIndex = weight / (height * height);

            bool isTooLow = bodyMassIndex <= 18.5;
            bool isNormal = bodyMassIndex > 18.5 && bodyMassIndex < 25; // && - AND
            bool isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex <= 30;
            bool isTooFat = bodyMassIndex > 30;

            bool isFat = isAboveNormal || isTooFat; // || - OR
                                                    // -1-
            if (isFat)
            {
                Console.WriteLine("You'f betgter loose some weight");
            }
            else
            {
                Console.WriteLine("Good shape");
            }
            // -2-
            if (!isFat)
            {
                Console.WriteLine("You're definitely not fat");
            }
            // -3-
            if (isTooLow)
            {
                Console.WriteLine("Not enough weight");
            }
            else if (isNormal)
            {
                Console.WriteLine("Hey! You are OK!");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Be careful");
            }
            else
            {
                Console.WriteLine("WARNING! To much weight!!!");
            }

            // ТЕРНАРНЫЙ оператор
            string description = age > 18 ? "You can dronk!" : "No! No! No! Stop!";
            Console.WriteLine(description);
        }
        static void solutionExOne() {
            Console.WriteLine("Please set a number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please set another number:");
            int b = int.Parse(Console.ReadLine());

            int max = a > b ? a : b;
            Console.WriteLine($"Max number is {max}");
        }
        static void forAndForeach() {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 2 == 0)
                {
                    Console.Write(numbers[j] + " ");
                }
            }

            Console.WriteLine();
            foreach (int val in numbers)
            {
                Console.Write(val + " ");
            }
        }
        static void forInsideFor() {
            int[] numbers = { 1, 0, -7, 3, 4, -1, -2, 3, -5, 7, 4, -6, 8, -2, 3, 2 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == 0)
                    {
                        Console.WriteLine($"({numbers[i]},{numbers[j]})\tIndex: {i},{j}");
                    }
                }
            }

            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        if (numbers[i] + numbers[j] + numbers[k] == 0)
                        {
                            Console.WriteLine($"({numbers[i]},{numbers[j]},{numbers[k]})\tIndex: {i},{j},{k}");
                        }
                    }
                }
            }
        }
        static void whileDoWhile() {
            int age = 30;

            while (age < 18)
            {
                Console.WriteLine("First while loop");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nice!");

            Console.WriteLine();
            do
            {
                Console.WriteLine("Do-while");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            } while (age < 18);
        }
        static void breakeContinius() {
            int[] numbers = { 0, 3, 2, 1, 5, 4, 6, 7, 8, 9 };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            foreach (int n in numbers)
            {
                // if (n % 2 == 0)
                //  {
                //      Console.WriteLine(n);
                //  }
                if (n % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(n);


            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number = {numbers[i]}");

                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers[i] == j)
                        break;
                    Console.Write($"{letters[j]}");
                }
                Console.WriteLine();
            }


            //numbers = { 1, 0, -7, 3, 4, -1, -2, 3, -5, 7, 4, -6, 8, -2, 3, 2 };

            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (counter == 3)
                    break;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == 0)
                    {
                        Console.WriteLine($"({numbers[i]},{numbers[j]})\tIndex: {i},{j}");
                        counter++;
                    }
                    if (counter == 3)
                        break;
                }
            }
        }
        static void swithDefault() {
            Console.WriteLine("Enter month number");
            int month = int.Parse(Console.ReadLine());
            string season;

            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Winter";
                    break;
                default:
                    throw new ArgumentException("Unexpected number of month");
            }
            Console.WriteLine(season);


            Console.WriteLine();
            Console.WriteLine("Please enter your wedding year");
            int weddingYear = int.Parse(Console.ReadLine());

            string name;

            switch (weddingYear)
            {
                case 5:
                    name = "Деревянная свадьба";
                    break;
                case 10:
                    name = "Оловянная свадьба";
                    break;
                case 15:
                    name = "Хрустальная свадьба";
                    break;
                case 20:
                    name = "Фарфоровая свадьба";
                    break;
                case 25:
                    name = "Серебрянная свадьба";
                    break;
                case 30:
                    name = "Жемчужная свадьба";
                    break;
                default:
                    name = "No answer";
                    break;
            }
            Console.WriteLine(name);
        }
        static void exOne() {
            Console.WriteLine("\tFibonachy numbers");
            Console.WriteLine("Enter lenght of array:");
            int len = int.Parse(Console.ReadLine());

            // check that L != 1!
            len = len == 1 ? 2 : len;
            int[] arr = new int[len];

            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i < len; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            Console.WriteLine();
            foreach (int n in arr)
            {
                Console.WriteLine(n);
            }
        }
        static void exTwo() {
            int count = 0;
            int a = 0;
            int sum = 0;

            while (count < 10)
            {
                Console.WriteLine("Enter a number");
                a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Stop point!");
                    break;
                }
                sum = sum + a;
                count++;
                Console.WriteLine($"Count is  {count},  Total sum is {sum}");
                Console.WriteLine();
            }
            Console.WriteLine($"Total count is {count}, total sum is {sum}, average is {sum / count}");
        }
        static void exThree() {
            Console.WriteLine("\tFactorials!");
            Console.WriteLine("Enter n for !n:");
            int n = int.Parse(Console.ReadLine());
            n = n == 0 ? 1 : n;

            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"Factorial of number {n} is {fact}");
        }
        static void exFour() {
            Console.WriteLine("\tLogin and password");
            string rightLogin = "johnsilver";
            string rightPassword = "qwerty";
            int tries = 3;


            int count = 0;
            bool systemVal = false;
            string login;
            string password;
            while (true)
            {
                Console.WriteLine("Please enter your Login:");
                login = Console.ReadLine();
                Console.WriteLine("Please enter your Password:");
                password = Console.ReadLine();

                if (login == rightLogin && password == rightPassword)
                {
                    Console.WriteLine("Welcome to System!");
                    systemVal = true;
                    break;
                }
                else
                {
                    count++;
                    if (tries == count)
                    {
                        Console.WriteLine("The number of available tries have been exceeded");
                        break;
                    }
                    else
                        Console.WriteLine("Try again");
                }
                Console.WriteLine();
            }
            string message = systemVal ? "You are login tu system" : "Forbidden!";
            Console.WriteLine(message);
        }

    }
}
