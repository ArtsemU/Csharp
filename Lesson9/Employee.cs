using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeStatus UnEmployeeStatus { get; set; }

        public Employee(string name, string surname)
        {
            FirstName = name;
            LastName = surname;
            UnEmployeeStatus = EmployeeStatus.UNFORMED;
        }

        public void ChangeEmployeeStatus(EmployeeStatus newStatus)
        {
            UnEmployeeStatus = newStatus;
        }

    }
}
