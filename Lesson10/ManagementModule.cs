using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lesson10
{
    class ManagementModule
    {
        private List<Card> _expiredCards;
        private List<Card> _unAssignCards;
        public Board Board { get; set; }
        public List<Card> ExpiredCards
        {
            get
            {
                _expiredCards = Board.Cards.Where(t => t.Ttl < DateTime.Now).ToList();

                return _expiredCards;
            }
        }
        public List<Card> UnAssignCards
        {
            get
            {
                _unAssignCards = Board.Cards.Where(t => t.Employee == null).ToList();

                return _unAssignCards;
            }
        }

        public ManagementModule()
        {

            _expiredCards = new List<Card>();
            _unAssignCards = new List<Card>();
        }
    }
}
