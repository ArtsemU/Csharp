using System;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Old Code
            // // создаем первую борду
            // Board boardFamily = new Board("My Task board");
            // myTrello.AddBoard(boardFamily);

            // // создаем трех пользователей и 3 карточки для них
            // Employee teacher = new Employee("Master", "Yoda");
            // Employee lukeSkywalker = new Employee("Luke", "Skywalker");
            // Employee leiaSkywalker = new Employee("Leia", "Skywalker");

            // Card teacherCard = new Card("Master card", "Main Jedi", teacher);
            // Card lukeCard = new Card("Brother task", "How save Galaxy", lukeSkywalker);
            //// Card leiaCard = new Card("Syster task", "How care about Galaxy", leiaSkywalker);



            // boardFamily.AddCardToBoard(teacherCard);
            // boardFamily.AddCardToBoard(lukeCard);
            // // Если не забуду, то обязательно спрошу про данную ситуацию. При таком создании Карточки
            // // можно обратится к leiaCard только через цикл. а что если нужен именно этот экземпляр?
            // // создать переменную и работать с ней?
            // boardFamily.AddCardToBoard(new Card("Syster task", "How care about Galaxy", leiaSkywalker));

            // teacher.UpdateStatus(Status.MANAGER);

            // // всем картам что полуочили назначение, меняем статус на Прогресс
            // foreach (var item in boardFamily.listCards)
            // {
            //     item.SetNewCardStatus(CardStatus.INPROGRESS);
            // }
            // boardFamily.ShowCardsOnBoard();
            // Console.WriteLine();

            // // Создаем 2ю борду
            // Board boardDarkSide = new Board("My dark side");
            // myTrello.AddBoard(boardDarkSide);

            // Employee emperor = new Employee("Emperor", "Palpatine", Status.MANAGER);
            // Employee darthVader = new Employee("Darth", "Vader");
            // Employee lexa = new Employee("Leha", "Aleha");

            // Card conquerGalaxy = new Card("Conquer the galaxy", "Power of dark side", emperor);
            // Card serveProtect = new Card("Server and Protect", "Power of dark side", darthVader);
            // Card lexaCard = new Card("Card for Lexa", "Power card!", lexa);

            // boardDarkSide.AddCardToBoard(conquerGalaxy);
            // boardDarkSide.AddCardToBoard(serveProtect);
            // boardDarkSide.AddCardToBoard(lexaCard);

            // conquerGalaxy.UpdateTTL(DateTime.Now);
            // foreach (var card in boardDarkSide.AllExpiredCards())
            // {
            //     Console.WriteLine($"Expiration status is: {card.CardTitle}"); 
            // }

            // Console.WriteLine();
            // boardDarkSide.ShowCardsOnBoard();
            // Console.ReadLine();
            #endregion
            Console.WriteLine("Welcome to MyTrello!");
            User user = new User("1111", "222");
            Employee empl1 = new Employee("Name1", "Surname1", Status.FREELANSE);
            Console.WriteLine(empl1.DisplayName());
            Console.WriteLine($"Employee status is {empl1.UnStatus}");
            empl1.UnStatus = Status.MANAGER;
            Console.WriteLine($"Employee status is {empl1.UnStatus}");

            Card testCard1 = new Card("Title1", "bla bla bla1", empl1);
            Card testCard2 = new Card("Title2", "bla bla bla2", empl1);
            testCard1.Status = CardStatus.POSTPONED;
            testCard1.Status = CardStatus.RESOLVED;
            testCard1.Status = CardStatus.TODO;
  
            testCard1.PrintHistoryToConcole();


            Console.ReadLine();
        }
    }
}
