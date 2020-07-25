using System;

namespace Labyrinth
{
    class Logic
    {
        // Лимит кол-ва шагов является статическим. Требуется для тестирования и отладки
        int limitSteps = 20;
        GameField field { get; set; }
        ObjectOnField objOnField { get; set; }
        UserCursor userPosition { get; set; }
        (int, int) currentPosition;

        public Logic()
        {
            // Создаем экземпляры классов
            field = new GameField();
            objOnField = new ObjectOnField();
            userPosition = new UserCursor();
        }
        public void MainLogick()
        {
            // Вызываем все необходимые методы перед началом игры
            field.SetDefValue();
            field.SetStartPosition();
            field.SetEndPosition();
            objOnField.SetRandomBlock(field.field);
            field.SetStaticObjectsOnField(objOnField.GetListBlocks());
            field.DisplayField();
            currentPosition = field.startPosition;

            // Ниже код противоречит DNRY. По хорошему надо вынести все в методы
            // Почему WASD а не курсорные клавиши? Просто так привычнее
            // Так и не понял как в ObjectOnField передать кол-во строк и столцов. Пришлось передавать само поле
            // хотя может так даже и лучше, ObjectOnField ничего не знает про само поле
            int count = 0;
            while (count < limitSteps || currentPosition == field.endPosition)
            {
                Console.WriteLine($"Step - {count + 1}");
                switch (Console.ReadKey(true).Key)
                {
                    // Идея с 'switch -case' подсмотрел в интернете, изначально планировалось if
                    case ConsoleKey.A:
                        if (objOnField.IsPossibleStep(field.field, userPosition.LeftStep(currentPosition)))
                        {
                            currentPosition = (currentPosition.Item1, currentPosition.Item2 - 1);
                            field.SetCurrentPosition(currentPosition);
                            field.DisplayField();
                        }
                        else
                        {
                            // Этот блок можно было бы и убрать. но тогда нет перерисовки массива
                            // Решил оставитьдля однотипности 
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
                        Console.WriteLine("Wrong key was pressed! Please use only 'W', 'A', 'S', 'D'");
                        break;
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
        }
    }
}
