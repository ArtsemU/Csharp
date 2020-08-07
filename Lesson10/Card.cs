using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
    class Card
    {
        // id - не реализован айдишник карточки
        public CardStatus CardStatus { get; set; }
        public string CardTitle { get; set; }
        public string Description { get; set; }
        public Employee AssignedEmployee { get; set; }
        public DateTime Ttl { get; set; }

        // не уверен что "Employee anEmployee = null" хорошая идея
        public Card(string title = "", string descr = "", Employee anEmployee = null)
        {
            CardTitle = title;
            Description = descr;
            AssignedEmployee = anEmployee;
            // Дефолтовый статус
            CardStatus = CardStatus.PLANNING;
            // Даем стандартно неделю на исполнение
            Ttl = DateTime.Now.AddDays(7);
        }
        public void SetNewCardStatus(CardStatus newStatus)
        {
            CardStatus = newStatus;
        }
        public void SetNewAssign(Employee assign)
        {
            AssignedEmployee = assign;
        }
        public void UpdateTTL(DateTime date)
        {
            Ttl = date;
        }
        public override string ToString()
        {
            return $"Card {CardTitle} with description: {Description}. " +
                $"Assigned to {AssignedEmployee?.FirstName}. Status: {CardStatus}. TTL till {Ttl.ToShortDateString()}";
        }
    }
}
