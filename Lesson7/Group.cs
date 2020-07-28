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
                Console.WriteLine($"Student: {student.FirstName} {student.LastName}" +
                    $" has average grade: {student.AverageGrade}");
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
