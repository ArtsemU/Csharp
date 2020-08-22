using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11
{
    class Student : Person
    {
        public Student(string name, string surname, Faculty faculty):base(name, surname)
        {
            Faculty = faculty;
        }

        public override bool Equals(Person person)
        {
            if (this.Faculty == person.Faculty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void PrintName()
        {
            Console.WriteLine($"Junior {Name} {Surame}");
        }
    }
}
