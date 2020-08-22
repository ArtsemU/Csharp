using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11
{
    class HeadOfDepartment : Professor
    {
        public HeadOfDepartment(string name, string surname, Faculty faculty) : base (name, surname,faculty)
        {
        }

        public override bool Equals(Person person)
        {
            if (this.Faculty == person.Faculty 
                && this.GetType().Name == person.GetType().Name)
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
            Console.WriteLine($"Dr. {Name} {Surame}");
        }
    }
}
