using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
    public class Employee : User
    {
        public Status UnStatus { get; set; }

        public Employee(string name, string surname, Status status = Status.UNFORMED): base(name, surname)
        {
            UnStatus = status;
        }

    }
}
