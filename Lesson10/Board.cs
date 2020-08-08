using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson10
{
    class Board
    {
        public List<Card> Cards { get; set; }
        public List<Employee> Team { get; set; } // не пригодился
        public string Title { get; set; }
        public Board(string title)
        {
            Title = title;
            Cards = new List<Card>();
            Team = new List<Employee>();
        }
        public void AddCardToBoard(Card card)
        {
            Cards.Add(card);
        }
        public void ShowCardsOnBoard()
        {
            Console.WriteLine($"There are next Cards on board {Title}:");
            foreach (var card in Cards)
            {
                Console.WriteLine(card.ToString());
            }
        }

        // пример реализации менеджерских запросов. правильнее было бы через линк
        // показать карточки, у которых вышел срок годности TTL
        public List<Card> AllExpiredCards()
        {
            List<Card> expiredCards = new List<Card>();
            expiredCards = (List<Card>)(from card in Cards
                          where card.Ttl < DateTime.Now
                          select card);

            return expiredCards;
        }

    }
}
