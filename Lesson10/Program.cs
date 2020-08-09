using System;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MyTrello!");
            User user = new User("name user", "Surname user");
            Employee empl1 = new Employee("empl1 name", "empl1 surname", Status.MANAGER);
            Employee empl2 = new Employee("empl2 name", "empl2 surname", Status.FREELANSE);
            Employee empl3 = new Employee("empl3 name", "empl3 surname", Status.EMPLOYEE);
            Employee empl4 = new Employee("empl4 name", "empl4 surname", Status.EMPLOYEE);

            Card card1 = new Card("Card 1", "Descr 1", empl1);
            Card card2 = new Card("Card 2", "Descr 1", empl1);
            Card card3 = new Card("Card 3", "Descr 1", empl2);
            Card card4 = new Card("Card 4", "Descr 1");

            Board board1 = new Board("My board 1");
            board1.Cards.Add(card1);
            board1.Cards.Add(card2);
            board1.Cards.Add(card3);
            board1.Cards.Add(card4);
            Console.WriteLine(board1.DisplayInfo());
            ManagementModule management = new ManagementModule();
            management.Board = board1;

            foreach (var item in management.UnAssignCards)
            {
                Console.WriteLine(item.Title);
            }
            Console.ReadLine();
        }
    }
}
