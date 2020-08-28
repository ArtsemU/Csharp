using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Lesson10
{

	[Serializable]
	public class Card : ITarget
	{
		public event EventHandler<CardStatus> CardStatusChangedEvent;
		private CardStatus _status;
		public string Title { get; set; }
		public string Description { get; set; }
		public List<CardStatus> HistoryStatusChanges { get; set; }
		public DateTime Ttl { get; set; }

		// EventHandler
		//public delegate void DelegatMessage();
		public event EventHandler testEventMessage;
		
		public CardStatus Status
		{
			get
			{
                if (_status == CardStatus.NEW)
                {
					testEventMessage?.Invoke(this, EventArgs.Empty);
				}
				return _status;
			}
			set
			{
				if (_status != CardStatus.RESOLVED)
				{
					_status = value;
					HistoryStatusChanges.Add(_status);
				}

				else throw new InvalidStatusException ("Cannot change final status");

				CardStatusChangedEvent?.Invoke(this, _status);
			}
		}

		public Employee Employee { get; set; }

		public Card()
		{

		}

		public Card(string title, string descr = "", Employee anEmployee = null)
		{
			HistoryStatusChanges = new List<CardStatus>();

			Title = title;
			Description = descr;
			Employee = anEmployee;
			Status = CardStatus.NEW;
			// устанавливаем ТТЛ для карты + 1 неделя по умолчанию
			Ttl = DateTime.Now.AddDays(7);
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

		public void HandleCardStatusChangedEvent()
		{
			Console.WriteLine("___Event handle___");
		}
	}
}
