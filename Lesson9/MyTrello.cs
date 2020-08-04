using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
    class MyTrello
    {
        // Кажется хорошей идеей перенести всю логику отчетности либо в отдельный класс, либо сюда
        public List<Board> ListBoards { get; set; }
        public MyTrello()
        {
            ListBoards = new List<Board>();
        }
        public void AddBoard(Board board)
        {
            ListBoards.Add(board);
        }
    }
}
