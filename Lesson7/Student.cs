using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata;
using System.Text;

namespace Lesson7
{
    class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public double AverageGrade { get; set; }
        public Dictionary<string, int> StudentGrade;
        Random random = new Random();

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentGrade = new Dictionary<string, int>();

        }
        // можно добавить класс Предметы и избавится от этой конструкции
        // Туда же перенести всю логику работы оценок
        public void SetRandomGrade()
        {
            StudentGrade.Add("Physics", random.Next(1, 6));
            StudentGrade.Add("Maths", random.Next(1, 6));
            StudentGrade.Add("Chemistry", random.Next(1, 6));
            StudentGrade.Add("English", random.Next(1, 6));
            double sum = 0;
            foreach (var grade in StudentGrade)
            {
                sum += grade.Value;
            }
            AverageGrade = sum / StudentGrade.Count;
        }

        public void PrintStudentGrades()
        {
            Console.WriteLine($"Grades for student {FirstName} {LastName}");
            foreach (var grade in StudentGrade)
            {
                Console.WriteLine($"{grade.Key} - {grade.Value}");
            }
            Console.WriteLine($"Average grade is _____ {AverageGrade}");
        }
    }
}
