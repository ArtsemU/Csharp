using System;

namespace Lesson11
{
    public abstract class Person
    {
        public Faculty Faculty { get; set; }
        public abstract string Name { get; set; }
        public string Surame { get; set; }
        public int Age
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public Person(string name, string surname)
        {
            Name = name;
            Surame = surname;
        }
        public abstract bool Equals(Person person);

        public abstract void PrintName();

    }
}
