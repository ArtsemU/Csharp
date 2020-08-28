using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
    // не совсем понятно почему данный подход нарушает сингл тон? 
    class MyTrello
    {
        delegate void myDel();
        // Кажется хорошей идеей перенести всю логику отчетности либо в отдельный класс, либо сюда
        public List<Board> Boards { get; set; }
        public MyTrello()
        {
            Boards = new List<Board>();
        }

        public void Message(object obj, EventArgs e)
        {
            Console.WriteLine("You try invoke start Card. Please change status before working");
        }

        public void ExpandMessage(object obj, EventArgs e)
        {
            Console.WriteLine("The method where some emails will be gnerated");
        }
    }
}
