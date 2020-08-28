using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using System.Xml;
using System.Threading;

namespace Lesson10
{
	class Program
	{
		static void Main(string[] args)
		{
			// В классе Card создали событие
			// В классе MyTrello создали подписчиков - 2 метода, в обоих для тестов выводим в консоль сообщения
			// в Мейне подписываемся
			// Сохраняем объекты Карты и Рабочий в txt, json и xml файлы

			Console.WriteLine("Welcome to MyTrello!");
			MyTrello myTrello = new MyTrello();

			Board board1 = new Board("My board 1");

			myTrello.Boards.Add(board1);

			User user = new User("name user", "Surname user");

			// Создаем пользователей
			Employee empl1 = new Employee("empl1 name", "empl1 surname", Status.MANAGER);
			Card card1 = new Card("Card 1", "Descr 1", empl1);

			card1.testEventMessage += myTrello.Message;
			card1.testEventMessage += myTrello.ExpandMessage;

			// Запись в файл
			string dataFolderPath = "TestFolder";
			string cardFileName = "Card.txt";
			string cardFileNameXml = "Card.xml";
			string cardFileNameJson = "Card.json";
			string cardFileName1 = ""; // для проверки исключения

			if (!Directory.Exists(dataFolderPath))
			{
				Directory.CreateDirectory(dataFolderPath);
			}

			//каждый раз удаляем все лишние файлы
			if (Directory.Exists(dataFolderPath))
			{
				var listOfFiles = Directory.GetFiles(dataFolderPath);
				if (listOfFiles != null)
				{
					foreach (var item in listOfFiles)
					{
						Console.WriteLine(item);
						File.Delete(item);
					}
				}
			}

			// txt
			SaveToFile(card1, dataFolderPath, cardFileName);

			// xml
			SaveToFileXML(empl1, dataFolderPath, cardFileNameXml);

			// а тут json
			string jsonCard = JsonSerializer.Serialize<Card>(card1);
			SaveToFileJson(jsonCard, dataFolderPath, cardFileNameJson);

			#region
			//Employee empl2 = new Employee("empl2 name", "empl2 surname", Status.FREELANSE);
			//Employee empl3 = new Employee("empl3 name", "empl3 surname", Status.EMPLOYEE);
			//Employee empl4 = new Employee("empl4 name", "empl4 surname", Status.EMPLOYEE);
			//// 5й создается в ручную
			//Console.WriteLine("Create Employee 5:");
			//Console.WriteLine("Enter name:");
			//string name5 = Console.ReadLine();
			//Console.WriteLine("Enter surname:");
			//string surname5 = Console.ReadLine();
			//Console.WriteLine("Enter status where(UNFORMED=1, EMPLOYEE = 2,MANAGER = 3, FREELANSE = 4, FIRED = 5):");
			//int status5 = int.Parse(Console.ReadLine());
			//Employee empl5 = new Employee(name5, surname5, (Status)status5);
			//// покажем что мы создали
			//Console.WriteLine(empl5.DisplayName());

			//Card card2 = new Card("Card 2", "Descr 1", empl1);
			//Card card3 = new Card("Card 3", "Descr 1", empl2);
			//Card card4 = new Card("Card 4", "Descr 1");
			//Card card5 = new Card("Card 5", "Descr 5", empl5);

			// Меняем статусы, пригодится позже
			//card1.Status = CardStatus.INPROGRESS;
			//card1.Status = CardStatus.REOPENED;
			//card1.Status = CardStatus.RESOLVED;
			//card1.Status = CardStatus.REOPENED;
			//card2.Ttl = DateTime.Now;


			//board1.Cards.Add(card1);
			//board1.Team.Add(card1.Employee);
			//board1.Cards.Add(card2);
			//board1.Team.Add(card2.Employee);
			//board1.Cards.Add(card3);
			//board1.Team.Add(card3.Employee);
			//board1.Cards.Add(card4);
			//board1.Team.Add(card4.Employee);

			// Проверим, что карточки могут распространятся только внутри команды
			//if (board1.Team.Contains(empl5))
			//{
			//    board1.Cards.Add(card5);
			//}
			//else Console.WriteLine("Only Teams member can be assign to Card");

			//Console.WriteLine(board1.DisplayInfo());
			//card1.PrintHistoryToConcole();
			//ManagementModule management = new ManagementModule();
			//management.Board = board1;

			//foreach (var item in management.UnAssignCards)
			//{
			//    Console.WriteLine(item.Title);
			//}

			//foreach (var item in management.ExpiredCards)
			//{
			//    Console.WriteLine(item.Title);
			//}

			//Console.WriteLine(board1.ToString());

			//// установим лимит для карточек на одну борду
			//while (board1.Cards.Count > 4)
			//{
			//    board1.Cards.RemoveAt(0);
			//}
			//Console.WriteLine(board1.ToString());
			#endregion

			// Event
			card1.CardStatusChangedEvent += (obj, e) =>
			{
				Console.WriteLine(obj.ToString());
				Console.WriteLine(e.ToString());
				Console.WriteLine($"Status changed by EventHandler {e}");
			};

			card1.Status = CardStatus.NEW;
			Console.WriteLine(card1.Status);
			Console.ReadLine();
		}

		private static void SaveToFileXML(Employee empl1, string dataFolderPath, string cardFileNameXml)
		{
			var xs = new XmlSerializer(typeof(Employee));
			TextWriter txtWriter = new StreamWriter(dataFolderPath + "/" + cardFileNameXml);
			xs.Serialize(txtWriter, empl1);
			txtWriter.Close();
		}

		private static void SaveToFile(Card card1, string dataFolderPath, string cardFileName)
		{
			try
			{
				File.WriteAllText($"{dataFolderPath}/{cardFileName}", $"New card was written: {card1.Title}; {card1.Description}; {card1.Ttl};");
			}
			catch (Exception e)
			{
				Console.WriteLine($"Exception was happeed {e.Message}");
			}
		}

		private static void SaveToFileJson(string card, string dataFolderPath, string cardFileName)
		{
			try
			{
				File.AppendAllText($"{dataFolderPath}/{cardFileName}", card);
				//File.WriteAllText($"{dataFolderPath}/{cardFileName}", card);
			}
			catch (Exception e)
			{
				Console.WriteLine($"Exception was happeed {e.Message}");
			}
		}
	}
}
