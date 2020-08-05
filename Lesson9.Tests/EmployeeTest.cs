using System;
using Xunit;

namespace Lesson9.Tests
{
	public class EmployeeTest
	{
		[Fact]
		public void Employee_FirstName_empty()
		{
			Employee employee = new Employee("", "");
			string expected = "";
 			Assert.Equal(employee.FirstName, expected);
		}
	}
}
