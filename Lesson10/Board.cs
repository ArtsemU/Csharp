using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson10
{
    class Board : ITarget
    {
       
        public List<Card> Cards { get; set; }
        public List<Employee> Team { get; set; } // не пригодился
        public string Title { get; set; }
        public string Description { get; set; }

        public Board(string title, string descr = "")
        {
            Title = title;
            Description = descr;

            Cards = new List<Card>();
            Team = new List<Employee>();
        }

        public void PrintCardsOnBoardToConsole()
        {
            Console.WriteLine($"There are next Cards on board {Title}:");
            foreach (var card in Cards)
            {
                Console.WriteLine(card.ToString());
            }
        }

        public string DisplayInfo()
        {
            return $"Board {Title}";
        }

        public override string ToString()
        {
            return $"Board {Title} contain {Cards.Count} cards";
        }

    }
}
