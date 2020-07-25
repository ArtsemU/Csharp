using System;

namespace Labyrinth
{
    class Logic
    {
        int limitSteps = 20;
        GameField field { get; set; }
        ObjectOnField objOnField { get; set; }
        UserCursor userPosition { get; set; }
        (int, int) currentPosition;

        public Logic()
        {
            field = new GameField();
            objOnField = new ObjectOnField();
            userPosition = new UserCursor();
        }
        public void MainLogick()
        {
            field.SetDefValue();
            field.SetStartPosition();
            field.SetEndPosition();
            objOnField.SetRandomBlock(field.field);
            field.SetStaticObjectsOnField(objOnField.GetListBlocks());
            field.DisplayField();
            currentPosition = field.startPosition;

            int count = 0;
            while (count < limitSteps || currentPosition == field.endPosition)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        if (objOnField.IsPossibleStep(field.field, userPosition.LeftStep(currentPosition)))
                        {
                            currentPosition = (currentPosition.Item1, currentPosition.Item2 - 1);
                            field.SetCurrentPosition(currentPosition);
                            field.DisplayField();
                        }
                        else
                        {
                            field.DisplayField();
                        }
                        break;
                    case ConsoleKey.S:
                        if (objOnField.IsPossibleStep(field.field, userPosition.DownStep(currentPosition)))
                        {
                            currentPosition = (currentPosition.Item1+1, currentPosition.Item2);
                            field.SetCurrentPosition(currentPosition);
                            field.DisplayField();
                        }
                        else
                        {
                            field.DisplayField();
                        }
                        break;
                    case ConsoleKey.D:
                        if (objOnField.IsPossibleStep(field.field, userPosition.RightStep(currentPosition)))
                        {
                            currentPosition = (currentPosition.Item1, currentPosition.Item2 + 1);
                            field.SetCurrentPosition(currentPosition);
                            field.DisplayField();
                        }
                        else
                        {
                            field.DisplayField();
                        }
                        break;
                    case ConsoleKey.W:
                        if (objOnField.IsPossibleStep(field.field, userPosition.UpStep(currentPosition)))
                        {
                            currentPosition = (currentPosition.Item1-1, currentPosition.Item2);
                            field.SetCurrentPosition(currentPosition);
                            field.DisplayField();
                        }
                        else
                        {
                            field.DisplayField();
                        }
                        break;
                    default:
                        Console.WriteLine("Some key was pressed");
                        break;
                }
                count++;
                if (currentPosition == field.endPosition)
                {
                    Console.WriteLine("You WIN!");
                    break;
                }
               
            };
        }
    }
}
