using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeStatus UnEmployeeStatus { get; set; }

        public Employee(string name, string surname, EmployeeStatus status = EmployeeStatus.UNFORMED)
        {
            FirstName = name;
            LastName = surname;
            UnEmployeeStatus = status;
        }

        public void ChangeEmployeeStatus(EmployeeStatus newStatus)
        {
            UnEmployeeStatus = newStatus;
        }

    }
}
