﻿using System;
using System.Collections.Generic;

namespace Lesson10
{
    class Card : ITarget
    {
        private CardStatus _status;
        public string Title { get; set; }
        public string Description { get; set; }
        public List<CardStatus> HistoryStatusChanges { get;  set; }
        public DateTime Ttl { get; set; } // расширить
        public CardStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                if (_status != CardStatus.RESOLVED)
                {                    
                    _status = value;
                    HistoryStatusChanges.Add(_status);
                }
                // else throw new ArgumentException("Cant change final status");
                // для тестов
                else Console.WriteLine("Cannot change final status");
            }
        }

        public Employee Employee { get; set; }

        public Card(string title, string descr = "", Employee anEmployee = null)
        {
            HistoryStatusChanges = new List<CardStatus>();

            Title = title;
            Description = descr;
            Employee = anEmployee;
            Status = CardStatus.NEW;
        }

        public string DisplayInfo()
        {
            return $"Card {Title} assigned {Employee?.FirstName}";
        }
        public void PrintHistoryToConcole()
        {
            if (HistoryStatusChanges.Count > 0)
            {
                foreach (var item in HistoryStatusChanges)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}