using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    class Group
    {
        public List<Student> Classmates { get; set; }
        public Group()
        {
            Classmates = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Classmates.Add(student);
        }

        public void PrintAllStudentName()
        {
            foreach (var student in Classmates)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }

        public void PrintGradesForStudents()
        {
            foreach (var student in Classmates)
            {
                student.PrintStudentGrades();
            }
        }
    }
}
