using System;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("FirstNamel", "LastName");
            Group TestGroup = new Group();
            // Используется массив для экономии времени
            // Что б не вводить значения с клавиатуры вручную
            string[][] ExampleList = new string[4][];
            ExampleList[0] = new string[2] { "Haruhi", "Suzumiya" };
            ExampleList[1] = new string[2] { "Shinji", "Ikari" };
            ExampleList[2] = new string[2] { "Yagami", "Light" };
            ExampleList[3] = new string[2] { "Lelouch", "Lamperouge" };

            foreach (var item in ExampleList)
            {
                TestGroup.AddStudent(new Student(item[0],item[1]));
            }
            foreach (var item in TestGroup.Classmates)
            {
                item.SetRandomGrade();
            }
            TestGroup.PrintAllStudentName();
            TestGroup.PrintGradesForStudents();
        }
    }
}
