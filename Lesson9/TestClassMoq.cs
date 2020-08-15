using System;
using System.Collections.Generic;
using System.Text;
using Moq;

namespace Lesson9
{
	public class TestClassMoq
	{

		public void TestTest()
		{
			var moq = new Mock<Employee>();
			moq.Setup(a => a.GetLastName()).Returns("Hello World!!!11");

			//Employee empl = new Employee("111", "222");
			//Console.WriteLine(empl.FirstName);
		}
	}
}
