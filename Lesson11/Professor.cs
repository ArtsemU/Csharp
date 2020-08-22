using System;

namespace Lesson11
{
    class Professor : Person
    {

        private string _name;

        public override string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                    _name = value;
            }
        }

        public Professor(string name, string surname, Faculty faculty) : base(name, surname)
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
            Console.WriteLine($"Prof. {Name} {Surame}");
        }
    }
}
