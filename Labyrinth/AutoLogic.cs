using System;
using System.Collections.Generic;
using System.Text;

namespace Labyrinth
{
    class AutoLogic
    {
        int limitSteps = 20;
        GameField field { get; set; }
        ObjectOnField objOnField { get; set; }
        UserCursor userPosition { get; set; }
        (int, int) currentPosition;

        public AutoLogic()
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
                Console.WriteLine($"Step: {count + 1}");
                if (objOnField.IsPossibleStep(field.field, userPosition.DownStep(currentPosition)))
                {
                    MoveDown();
                    objOnField.Passed.Add(currentPosition);
                }
                else if (objOnField.IsPossibleStep(field.field, userPosition.LeftStep(currentPosition)))
                {
                    MoveLeft();
                    objOnField.Passed.Add(currentPosition);
                }
                else if (objOnField.IsPossibleStep(field.field, userPosition.RightStep(currentPosition)))
                {
                    MoveRight();
                    objOnField.Passed.Add(currentPosition);
                }
                else
                { 
                    MoveUp();
                    objOnField.Passed.Add(currentPosition);
                }
                            
                count++;
                if (currentPosition == field.endPosition)
                {
                    Console.WriteLine("You WIN!");
                    break;
                }
                else if (count == limitSteps)
                {
                    Console.WriteLine("Sorry! You lose!");
                }

            };

            Console.WriteLine("End");
            Console.ReadLine();
        }

        private void MoveUp()
        {
            if (objOnField.IsPossibleStep(field.field, userPosition.UpStep(currentPosition)))
            {
                currentPosition = (currentPosition.Item1 - 1, currentPosition.Item2);
                field.SetCurrentPosition(currentPosition);
                field.DisplayField();
            }
            else
            {
                field.DisplayField();
            }
        }

        private void MoveRight()
        {
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
        }

        private void MoveDown()
        {
            if (objOnField.IsPossibleStep(field.field, userPosition.DownStep(currentPosition)))
            {
                currentPosition = (currentPosition.Item1 + 1, currentPosition.Item2);
                field.SetCurrentPosition(currentPosition);
                field.DisplayField();
            }
            else
            {
                field.DisplayField();
            }
        }

        private void MoveLeft()
        {
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
        }
    }
}
