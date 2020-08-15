using System;
using Xunit;
using Moq;

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
		[Fact]
		public void Employee_FirstName_DefaultStatus()
		{
			Employee employee = new Employee("", "");
			EmployeeStatus defStatus = EmployeeStatus.UNFORMED;
			Assert.Equal(employee.UnEmployeeStatus, defStatus);
		}
		[Fact]
		public void Employee_FirstName_FirstNameRequired()
		{
			Employee employee = new Employee("", null);
			Assert.NotNull(employee);
		}
		[Fact]
		public void Employee_FirstName_LastNameRequired()
		{
			Employee employee = new Employee(null, "");
			Assert.NotNull(employee);
		}
		[Fact]
		public void Test()
		{
			var moq = new Mock<IEmploee>();
			moq.Setup(a => a.GetLastName()).Returns("Hello World!");

			var s = moq.Object.GetLastName();
			Assert.NotNull(s);
			Assert.Equal("Hello World!", s);
		}
	}
}
