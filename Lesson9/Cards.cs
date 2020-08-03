using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
    class Cards
    {
        // id
        public CardStatus CardStatus { get; set; } = CardStatus.PLANNING;
        public string Title { get; set; }
        public string Description { get; set; }
        public Employee AssignEmployee { get; set; }
        public DateTime Ttl { get; set; }

        public Cards(string title = "", string descr = "", Employee anEmployee = null)
        {
            CardStatus = CardStatus.PLANNING;
        }
        public void SetNewCardStatus(CardStatus newStatus)
        {
            CardStatus = newStatus;
        }
        public void SetNewAssign(Employee assign)
        {
            AssignEmployee = assign;
        }
        public override string ToString()
        {
            return $"Card {Title} with description: {Description}. " +
                $"Assigned to {AssignEmployee}. Status: {CardStatus}. TTL till {Ttl}";
        }
    }
}
