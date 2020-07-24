using System;

namespace Labyrinth
{
    class Program
    {
        static void Main(string[] args)
        {
            //GameField gameField = new GameField();
            //ObjectOnField objOnField = new ObjectOnField();
            Logic logic = new Logic();
            logic.Game();
            logic.gameField.SetDefValue(gameField.field);
            Console.WriteLine("Display def field:");
            gameField.DisplayField();
            //gameField.SetRandomBlock();
            objOnField.SetRandomBlock(gameField.field);

            gameField.SetStartPosition();
            gameField.SetEndPosition();
            objOnField.SetRandomBlock(gameField.field);
            gameField.UpdateField(objOnField.GetRandomBlock());

            Console.WriteLine("Display set field:");
            gameField.DisplayField();

            // test
            Console.WriteLine("TEST");
            int count = 0;
            while(count < 10)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("Key A was pressed");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("Key S was pressed");
                        break;
                    case ConsoleKey.D:  
                        Console.WriteLine("Key D was pressed");
                        break;
                    case ConsoleKey.W:
                        Console.WriteLine("Key W was pressed");
                        break;
                    default:
                        Console.WriteLine("Some key was pressed");
                        break;
                }
                count++;
            };


        }
    }
}
