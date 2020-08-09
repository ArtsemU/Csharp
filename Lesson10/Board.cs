using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson10
{
    class Board : ITarget
    {
        #region
        //private List<Card> _expiredCards;
        //private List<Card> _unAssignCards;
        //public List<Card> ExpiredCards
        //{
        //    get
        //    {
        //        _expiredCards = (List<Card>)(from card in Cards
        //                                    where card.Ttl < DateTime.Now
        //                                    select card);
        //        return _expiredCards;
        //    }
        //}
        //public List<Card> UnAssignCards
        //{
        //    get
        //    {
        //        _unAssignCards = (List<Card>)(from card in Cards
        //                                    where card.Employee == null
        //                                    select card);
        //        return _unAssignCards;
        //    }
        //}
        #endregion
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

            //_expiredCards = new List<Card>();
            //_unAssignCards = new List<Card>();
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
    }
}
