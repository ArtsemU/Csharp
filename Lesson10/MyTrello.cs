using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
    // не совсем понятно почему данный подход нарушает сингл тон? 
    class MyTrello
    {
        // Кажется хорошей идеей перенести всю логику отчетности либо в отдельный класс, либо сюда
        public List<Board> Boards { get; set; }
        public MyTrello()
        {
            Boards = new List<Board>();
        }
    }
}
