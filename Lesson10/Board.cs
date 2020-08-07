using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
    class Board
    {
        public List<Card> listCards { get; set; }
        public List<Employee> listEmployee { get; set; } // не пригодился
        public string boardTitle { get; set; }
        public Board(string title)
        {
            boardTitle = title;
            listCards = new List<Card>();
        }
        public void AddCardToBoard(Card card)
        {
            listCards.Add(card);
        }
        public void ShowCardsOnBoard()
        {
            Console.WriteLine($"There are next Cards on board {boardTitle}:");
            foreach (var card in listCards)
            {
                Console.WriteLine(card.ToString());
            }
        }

        // пример реализации менеджерских запросов. правильнее было бы через линк
        // показать карточки, у которых вышел срок годности TTL
        public List<Card> AllExpiredCards()
        {
            List<Card> expired = new List<Card>();
            foreach (var card in listCards)
            {
                if (card.Ttl < DateTime.Now)
                {
                    expired.Add(card);
                }
            }
            return expired;
        }

    }
}
