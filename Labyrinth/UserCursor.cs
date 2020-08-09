namespace Labyrinth
{
    class UserCursor
    {
        (int, int) currentPosition { get; set; }
        // Простой класс. 4 метода, которые двигают курсор в нужную сторону
        // По хорошему надо реализовать два отдельных поля - текущее положение и будущее положение
        // тогда можно без проблем отрисовать пройденный путь (изначально была задумка букой 'p')
        // далее это будет видно
        public UserCursor()
        {

        }
        //public (int, int) GetCurrentPosition()
        //{
        //    return currentPosition;        
        //}
        public (int, int) LeftStep((int, int) currentPosition)
        {
            return (currentPosition.Item1, currentPosition.Item2 - 1);
        }
        public (int, int) RightStep((int, int) currentPosition)
        {
            return (currentPosition.Item1, currentPosition.Item2 + 1);
        }
        public (int, int) UpStep((int, int) currentPosition)
        {
            return (currentPosition.Item1 - 1, currentPosition.Item2);
        }
        public (int, int) DownStep((int, int) currentPosition)
        {

            return (currentPosition.Item1 + 1, currentPosition.Item2);
        }
    }
}
