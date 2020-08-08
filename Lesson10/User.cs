using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User(string name, string surname)
        {
            FirstName = name;
            LastName = surname;
        }

        virtual public string DisplayName()
        {
            return $"Name: {FirstName}, Surname: {LastName}";
        }
    }
}
